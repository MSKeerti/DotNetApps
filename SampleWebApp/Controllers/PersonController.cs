using Microsoft.AspNetCore.Mvc;
using SampleWebApp.Models;
using System.Security.Cryptography.X509Certificates;

namespace SampleWebApp.Controllers
{
    public class PersonController : Controller
    {
        [HttpGet("/people")]
        public IActionResult GetPeople()
        {
            //Get the model class and do something
            var people = PersonOperations.GetPeople();


            //Display a View
            return View("PeopleList", people);
        }

        [HttpGet("/search/{pAadhar}")]
        public IActionResult GetPersonDetail(string pAadhar)
        {
            //call model class method
            var found = PersonOperations.Search(pAadhar);

            //return the view with matching person object
            return View("Search", found);
        }
            [HttpGet("/people/of/age/{pstartAge}/{pendAge}")]

            public IActionResult GetPeopleWithinAge(int pstartAge, int pendAge)
            {

                var Age= PersonOperations.PeopleofAge(pstartAge, pendAge);

                return View("PeopleofAge", Age);
            }

        [HttpGet("/create")]
        public IActionResult Create() { 
           return View("Create", new Person());
        }

        [HttpPost("/create")]
        public IActionResult Create([FromForm] Person p) 
        { 
            //Call model method from personOperations
            PersonOperations.CreateNew(p);
            return View("PeopleList",PersonOperations.GetPeople());
        }

        [HttpGet("/edit/{pAadhar}")]
        public IActionResult Edit(string pAadhar)
        {
            var found = PersonOperations.Search(pAadhar);
            return View("Edit", found);
        }

        [HttpPost("/edit/{pAadhar}")]
        public IActionResult Edit([FromForm] Person p)
        {
            var found = PersonOperations.Search(p.Aadhar);
            found.Email = p.Email;
            found.Age = p.Age;
            found.Name = p.Name;
            return View("PeopleList", PersonOperations.GetPeople());
        }
        
        }
    }

