using Microsoft.AspNetCore.Mvc;
using ModelsLib;
using Services;

namespace HRISAppMVC.Controllers
{
    public class DepartmentsControllers : Controller
    {
        private readonly DepartmentServices _services;

        public DepartmentsControllers(DepartmentServices services)
        {
            _services = services;
        }
        // GET: DepartmentsControllers
        public ActionResult Index()
        {
            List<Department> deptList = _services.GetDepartment();

            return View(deptList);
        }

        // GET: DepartmentsControllers/Details/5
        public ActionResult Details(int id)
        {

            return View();
        }

        // GET: DepartmentsControllers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DepartmentsControllers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Department dept)
        {
            try
            {


                TempData["message"] = _services.AddDepartment(dept);
                return RedirectToAction(nameof(Index));


            }
            catch
            {
                return View();
            }
        }

        // GET: DepartmentsControllers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DepartmentsControllers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DepartmentsControllers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DepartmentsControllers/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
