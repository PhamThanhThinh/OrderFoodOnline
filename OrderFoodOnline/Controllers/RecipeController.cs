using Microsoft.AspNetCore.Mvc;

namespace OrderFoodOnline.Controllers
{
  public class RecipeController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
