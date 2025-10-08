using Microsoft.AspNetCore.Mvc;

namespace MedAi.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult SignUpPage()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return RedirectToAction("FavoriteMealsPage", "Meals");
        }
    }
}
