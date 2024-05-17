using medical_plaza.DAL;
using medical_plaza.Models;
using Microsoft.AspNetCore.Mvc;

namespace medical_plaza.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class DoctorsController : Controller
    {
        AppDbContext _dbContext;

        public DoctorsController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            List<Doctors> Doctors = _dbContext.Doctors.ToList();
            return View(Doctors);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Doctors doctors) 
        {
            if (!ModelState.IsValid)
            {
            return View();
            }
            _dbContext.Doctors.Add(doctors);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");   
        }
        public IActionResult Delete(int? id) 
        {
         var Doctors =_dbContext.Doctors.FirstOrDefault(x => x.Id == id);
            _dbContext.Doctors.Remove(Doctors);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
