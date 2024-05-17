

using medical_plaza.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace medical_plaza.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }
       
      
    }
}
