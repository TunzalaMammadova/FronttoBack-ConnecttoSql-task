using System;
using Microsoft.AspNetCore.Mvc;

namespace FrontoBack_ConnectSql_task.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
