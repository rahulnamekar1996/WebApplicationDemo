using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplicationDemo.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult EmployeeDetails()
        {
            List<string> cities = new List<string>()
            {
                "Pune", "Mumbai","Nagpur","Delhi"
            };
            List<string> Department = new List<string>()
            {
                "Quality", "Production","Admin","Mainatainance"
            };
            ViewData["cities"] = new SelectList(cities);
            ViewData["Department"]=new SelectList(Department);
            return View();
           
        }
        [HttpPost]
        public IActionResult EmployeeDetails(IFormCollection form)
        {
            ViewBag.Name = form["Employeename"];
            ViewBag.MiddleName = form["MiddleName"];
            ViewBag.SirName = form["SirName"];
            ViewBag.Gender = form["gender"];
            ViewBag.Email = form["email"];
            ViewBag.City = form["cities"];
            ViewBag.Department = form["Department"];
            ViewBag.Salary = form["EmployeeSalary"];
            return View("Display");
        }
    }
}
