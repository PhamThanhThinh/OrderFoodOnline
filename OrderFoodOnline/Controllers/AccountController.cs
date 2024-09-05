using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OrderFoodOnline.Models;

namespace OrderFoodOnline.Controllers
{
  public class AccountController : Controller
  {
    private readonly SignInManager<ApplicationUser> _signInManager;
    
    public AccountController(SignInManager<ApplicationUser> signInManager)
    {
      _signInManager = signInManager;
    }

    public IActionResult Login()
    {
      return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login(LoginViewModel login)
    {
      if (ModelState.IsValid)
      {
        var user = new ApplicationUser { Email = login.Email };
        var result = await _signInManager.PasswordSignInAsync(user, login.Password, false, false);
        if (result.Succeeded)
        {
          return RedirectToAction("Index", "Home");
        }
        // xử lý ngoại lệ
        ModelState.AddModelError("", "Không đăng nhập được");
      }

      return View(login);
    }

    public IActionResult Register()
    {
      return View();
    }
  }
}
