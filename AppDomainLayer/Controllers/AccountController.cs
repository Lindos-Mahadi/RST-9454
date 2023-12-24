using AppDomainLayer.Data;
using AppDomainLayer.Models.Account;
using AppDomainLayer.Models.ViewModel;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
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
        public async Task<IActionResult> Login(LoginUserViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // Check if the user exists in the database
                    var user = await _context.User.FirstOrDefaultAsync(u => u.UserName == model.UserName && u.IsActive);

                    if (user != null)
                    {
                        // Use PasswordHasher to verify the password
                        var passwordHasher = new PasswordHasher<User>();
                        var passwordVerificationResult = passwordHasher.VerifyHashedPassword(null, user.PasswordHash, model.Password);

                        if (passwordVerificationResult == PasswordVerificationResult.Success)
                        {
                            // Authentication successful
                            var claimsIdentity = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, model.UserName) }, CookieAuthenticationDefaults.AuthenticationScheme);
                            var principal = new ClaimsPrincipal(claimsIdentity);
                            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                            HttpContext.Session.SetString("UserName", model.UserName);

                            // Redirect to a dashboard or home page
                            return RedirectToAction("Index", "Home");
                        }
                        else
                        {
                            ModelState.AddModelError(string.Empty, "Invalid password");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "User not found or inactive");
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                ModelState.AddModelError(string.Empty, "An error occurred while processing your request");
            }

            return View(model);
        }

        public IActionResult LogOut()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }
        [AcceptVerbs("Post", "Get")]
        public async Task<IActionResult> UserNameIsExist(string userName)
        {
            var usrName = await _context.User.Where(u => u.UserName == userName).FirstOrDefaultAsync();
            if (usrName != null)
            {
                return Json($"UserName {userName} is already exist");
            }
            else
            {
                return Json(true);
            }
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
                    // Use PasswordHasher to hash the password
                    var passwordHasher = new PasswordHasher<User>();
                    var hashedPassword = passwordHasher.HashPassword(null, model.Password);
                    var user = new User()
                    {
                        UserName = model.UserName,
                        Email = model.Email,
                        PasswordHash = hashedPassword,
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
