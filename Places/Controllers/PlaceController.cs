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
    [HttpPost("/places")]
    public ActionResult Create()
    {
      string cityName = Request.Form["cityName"]
      Place place = new Place(cityName);
      List<Place> allPlaces = Place.GetInstances();
      return View("../Home/Index", allPlaces);

      // Model = list of places
      // return View("../Home/Index", place);
      // Model = a place
    }
  }
}
