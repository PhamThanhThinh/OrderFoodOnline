using Microsoft.AspNetCore.Mvc;
using OrderFoodOnline.Models;

namespace OrderFoodOnline.Controllers
{
  public class RecipeController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
    [HttpPost]
    public IActionResult GetRecipeCard([FromBody] List<Recipe> recipes)
    {
      return PartialView("_RecipeCard", recipes);
    }
    public IActionResult Search([FromQuery] string recipe)
    {
      ViewBag.Recipe = recipe;
      return View();
    }
  }
}
