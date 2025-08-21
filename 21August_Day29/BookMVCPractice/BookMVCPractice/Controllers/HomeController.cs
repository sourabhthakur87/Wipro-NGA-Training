using System.Diagnostics;
using BookMVCPractice.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookMVCPractice.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()

        {
            ViewData["text"] = "This is a sample text from ViewData";
            ViewBag.text1 = "This is example of ViewBag";

            TempData["text2"] = "This is Example of TempData";
            


            return View();
        }

        public IActionResult MyForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ShowData(IFormCollection data)
        {
            //ViewBag.Name = name;
            //ViewBag.gender = gender;
            //return View();

            ViewBag.Name = data["name"];
            ViewBag.gender = data["gender"];
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //[Authorize]
        public IActionResult Booklist() {
            List<StudentModel> Student = new List<StudentModel>()
           {
                new StudentModel() { rollNo = 1, Name = "John", age = 20, gender = "Male"},
                new StudentModel() { rollNo = 2, Name = "John Thakur", age = 22, gender = "Male"},
                new StudentModel() { rollNo = 3, Name = "shyam", age = 21, gender = "Male"},
                new StudentModel() { rollNo = 4, Name = "dave", age = 12, gender = "Male"}

           };
            return View(Student);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
