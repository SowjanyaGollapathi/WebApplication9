using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            IList<Customer> customers = new List<Customer>();
            customers.Add(new Customer() { ID = 123, Name = "abc", Address = "x location" });
            customers.Add(new Customer() { ID = 456, Name = "def", Address = "y location" });
            customers.Add(new Customer() { ID = 789, Name = "ghi", Address = "z location" });
            ViewData["customers"] = customers;
            return View();
        }
    }
}
