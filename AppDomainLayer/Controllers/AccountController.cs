using AppDomainLayer.Data;
using AppDomainLayer.Models.Account;
using AppDomainLayer.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult Login(LoginSignUpViewModel model)
        {
            try
            {

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return View();
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
