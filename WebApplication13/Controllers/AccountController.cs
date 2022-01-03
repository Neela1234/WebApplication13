using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication13.Models;

namespace WebApplication13.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            IList<Account> accounts = new List<Account>();
            accounts.Add(new Account() { ID = 123, Name = "neela", Address = "khammam" });
            accounts.Add(new Account() { ID = 345, Name = "AMMU", Address = "hyderabad" });
            accounts.Add(new Account() { ID = 456, Name = "kousik", Address = "vijayawada" });
            ViewData["accounts"] = accounts;


            return View();
        }
    }
}
