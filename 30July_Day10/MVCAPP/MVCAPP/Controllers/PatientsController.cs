using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCAPP.Data;
using MVCAPP.Models;

namespace MVCAPP.Controllers
{
    public class PatientsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public PatientsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Patients> plist = _context.patients.ToList();
            return View(plist);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(string name, string alergies, string mobile)
        {
            // Here you would typically save the patient data to a database
            // For now, we will just return a view with the submitted data
            Patients p = new Patients();
            p.Name = name;
            p.Alergies = alergies;
            p.Mobile = mobile;
            _context.patients.Add(p);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Patients p = _context.patients.Find(id);
            if (p == null)
            {
                return NotFound();
            }
            return View(p);
        }

        [HttpPost]

        public IActionResult Edit(Patients p)
        {
            _context.patients.Update(p);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Patients p = _context.patients.Find(id);
            if (p == null)  
            {
                return NotFound();
            }
            return View(p);
        }

  
        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteMethod(Patients p)
        {
            var patient = _context.patients.Find(p.Id);
            if (patient == null)
            {
                return NotFound();
            }
            _context.patients.Remove(patient);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
