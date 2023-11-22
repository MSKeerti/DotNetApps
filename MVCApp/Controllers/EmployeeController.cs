using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;
using System.ComponentModel;

namespace MVCApp.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet("/employee")] //this is routing configuration
        public IActionResult GetEmployee()
        {
            //get a model and do something
            var employee = EmployeeOperations.GetEmployee();
            return View("EmployeeList", employee);
        }
        [HttpGet("/search/{eEmpId}")]
        public IActionResult GetEmployeeDetail(int eEmpId)
        {
            //call model class method
            var found = EmployeeOperations.Search(eEmpId);

            //return the view with matching person object
            return View("Search", found);

        }

        [HttpGet("/create")]

        public IActionResult Create()
        {
            return View("Create", new Employee());

        }
        [HttpPost("/create")]
        public IActionResult Create([FromForm] Employee e)
        {
            EmployeeOperations.CreateNew(e);
            return View("EmployeeList", EmployeeOperations.GetEmployee());
        }

        [HttpGet("/edit/{eEmpId}")]
        public IActionResult Edit(int eEmpId)
        {
            var found = EmployeeOperations.Search(eEmpId);
            return View("Edit", found);

        }
        [HttpPost("/edit/{eEmpId}")]

        public IActionResult Edit(int eEmpId, [FromForm] Employee e)
        {
            var found = EmployeeOperations.Search(e.EmpId);
            found.Designation = e.Designation;
            found.Salary = e.Salary;
            found.empname = e.empname;
            return View("EmployeeList", EmployeeOperations.GetEmployee());
        }
    }
}