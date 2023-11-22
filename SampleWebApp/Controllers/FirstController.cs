using Microsoft.AspNetCore.Mvc;

namespace SampleWebApp.Controllers
{
    public class FirstController : Controller
    {
        [HttpGet("/greet")]
        public IActionResult Greet()
        {
            return Ok("Hello, I'm a web function");
        }

        [HttpGet("/simplegreet/{pName}")]
        public string SimpleGreet(string pName)
        {
            return $"Welcome to MVC, {pName}";

        }

        [HttpGet("/getnames")]
        public List<string> GetNames()
        {
            var names = new List<string>() { "Eena", "Meena", "Deeka" };
            return names;
        }

        [HttpGet("/add/{pName}/{pMarks}/{isPasssed?}")]
        public string AddData(string pName, int pMarks, bool isPassed=true)
        {
            return $"{pName} secured {pMarks} in the exam and status of passing is {isPassed}";
        }

        [HttpGet("/main")]
        public IActionResult GetIndexPage()
        {
            ViewBag.ReturnValue = "Data passed from controller to View";
            return View("MainPage");
        }

    }
}

