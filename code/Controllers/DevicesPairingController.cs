using Microsoft.AspNetCore.Mvc;

namespace MedAi.Controllers
{
    public class DevicesPairingController : Controller
    {
        public IActionResult DevicesPage()
        {
            return View();
        }

        public IActionResult ActivityDashboard()
        {
            return View();
        }

        public IActionResult FamilyComparison()
        {
            return View();
        }

        public IActionResult HistoricalTrends()
        {
            return View();
        }
    }
}
