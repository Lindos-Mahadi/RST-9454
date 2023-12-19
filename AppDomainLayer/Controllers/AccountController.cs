using AppDomainLayer.Data;
using AppDomainLayer.Models.Account;
using AppDomainLayer.Models.ViewModel;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace AppDomainLayer.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginSignUpViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var user = await _context.User.Select(u => u.UserName == model.UserName && u.Password == model.Password).SingleOrDefaultAsync();

                    if (user != null)
                    {
                        var claimsIdentity = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, model.UserName) }, CookieAuthenticationDefaults.AuthenticationScheme);
                        var principal = new ClaimsPrincipal(claimsIdentity);
                        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                        HttpContext.Session.SetString("UserName", model.UserName);
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        TempData["errorMessage"] = "Invalid UserName or Password!";
                        return View(model);
                    }
                }
                else
                {
                    TempData["errorMsg"] = "User Not Found!";
                    return View(model);
                }

            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public IActionResult LogOut()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> SignUp(SignUpUserViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var user = new User()
                    {
                        UserName = model.UserName,
                        Email = model.Email,
                        Password = model.Password,
                        Mobile = model.Mobile,
                        IsActive = model.IsActive,
                        //IsRemember = model.IsRemember,
                    };
                    await _context.User.AddAsync(user);
                    await _context.SaveChangesAsync();
                    TempData["successMSG"] = "You are eligible to login, Please fill own credential's then login!.";
                    return RedirectToAction("Login");
                }
                else
                {
                    TempData["errorMessage"] = "Empty form can't be submitted!";
                    return View(model);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
