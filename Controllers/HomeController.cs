using first.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace first.Controllers
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
            Employee employee = new Employee {
                EmployeeName ="Praveen",
                EmployeeId = 752,
                EmployeeAge =23,
                Salary =20000
            };
       List<Employee> employees = new List<Employee>
{               
            new Employee
            {
                EmployeeName ="Ratheesh",
                EmployeeId = 750,
                EmployeeAge =22,
                Salary =20000
            },
            new Employee
            {
                EmployeeName ="Alwin",
                EmployeeId = 753,
                EmployeeAge =24,
                Salary =20000
            } };
            var empinfo = (from emp1 in employees select emp1).ToList();

            return View(empinfo);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
