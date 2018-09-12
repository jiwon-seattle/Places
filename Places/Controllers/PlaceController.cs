using Microsoft.AspNetCore.Mvc;
using Places.Models;
using System;
using System.Collections.Generic;

namespace Places.Controllers
{
  public class PlaceController : Controller
  {
    [HttpGet("/places/new")]
    public ActionResult CreatePlace()
    {
      return View();
    }
  }
}
