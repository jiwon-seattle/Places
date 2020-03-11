using Microsoft.AspNetCore.Mvc;
using Places.Models;
using System;
using System.Collections.Generic;

namespace Places.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
        return View();
        }
    }
}
