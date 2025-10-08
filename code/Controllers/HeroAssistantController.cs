using Microsoft.AspNetCore.Mvc;

namespace MedAi.Controllers
{
    public class HeroAssistantController : Controller
    {
        public IActionResult HerosChat()
        {
            return View();
        }
    }
}
