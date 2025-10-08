using Microsoft.AspNetCore.Mvc;

namespace MedAi.Controllers
{
    public class FamilyGamificationController : Controller
    {
        #region 
        public IActionResult DailyChallenge()
        {
            return View();
        }
        #endregion

        public IActionResult MyAchievements()
        {
            return View();
        }

        #region 
        public IActionResult FamilyLeaderboard()
        {
            return View();
        }
        #endregion

        #region 
        public IActionResult FamilyProgress()
        {
            return View();
        }
        #endregion

        
    }
}
