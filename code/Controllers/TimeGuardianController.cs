using Microsoft.AspNetCore.Mvc;

namespace MedAi.Controllers
{
    public class TimeGuardianController : Controller
    {
        public IActionResult TimeDashboard()
        {
            return View();
        }

        public IActionResult TimeSetup()
        {
            return View();
        }
    }
}
