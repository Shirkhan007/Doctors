using Microsoft.AspNetCore.Mvc;

namespace medical_plaza.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       
    }
}
