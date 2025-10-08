using Microsoft.AspNetCore.Mvc;

namespace MedAi.Controllers
{
    public class MealsController : Controller
    {
        public IActionResult FavoriteMealsPage()
        {
            return View();
        }

        public IActionResult MealsPlanningPage()
        {
            return View();
        }

        public IActionResult GeneratedMealPlanPage()
        {
            return View();
        }

        public IActionResult GroceryListPage()
        {
            return View();
        }

        public IActionResult MyMealsPage()
        {
            return View();
        }
    }
}
