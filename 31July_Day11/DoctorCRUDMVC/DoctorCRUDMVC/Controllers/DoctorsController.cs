using DoctorCRUDMVC.Data;
using DoctorCRUDMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DoctorCRUDMVC.Controllers
{
    public class DoctorsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DoctorsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Doctors> doctors = _context.doctors.ToList();
            return View(doctors);
        }


        [HttpGet]
        public IActionResult AddDoctor()
        {
            return View();
        }

        [HttpPost]

        public IActionResult AddDoctor(string name,string clinicname,int mobilenumber)
        {
            Doctors d = new Doctors();
            d.Name = name;
            d.ClinicName = clinicname;
            d.MobileNumber = mobilenumber;
            _context.doctors.Add(d);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditDoctor(int id)
        {
            Doctors d = _context.doctors.Find(id);
            if (d == null)
            {
                return NotFound();
            }
            return View(d);
        }
        [HttpPost]
        public IActionResult EditDoctor(Doctors d)
        {
            _context.doctors.Update(d);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Doctors d = _context.doctors.Find(id);
            if (d == null)
            {
                return NotFound();
            }
            return View(d);
        }


        [HttpPost]
        public IActionResult Delete(Doctors d)
        {
            var doc = _context.doctors.Find(d.Id);
            if (doc == null)
            {
                return NotFound();
            }
            _context.doctors.Remove(doc);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
