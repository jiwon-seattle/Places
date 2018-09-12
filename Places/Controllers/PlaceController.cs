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
      string cityName = Request.Form["cityName"];
      string cityDescription = Request.Form["cityDescription"];
      int cityYear = int.Parse(Request.Form["cityYear"]);
      Place place = new Place(cityName, cityDescription, cityYear);
      List<Place> allPlaces = Place.GetInstances();
      return View("../Home/Index", allPlaces);

      // Model = list of places
      // return View("../Home/Index", place);
      // Model = a place
    }

    [HttpGet("/places/{id}")]
    public ActionResult Details(int id)
    {
      Place place = Place.Find(id);
      return View(place);
    }

    [HttpPost("/places/delete")]
    public ActionResult Clear()
    {
      Place.ClearAll();
      List <Place> allPlaces = Place.GetInstances();
      return View("../Home/Index", allPlaces);
    }
  }
}
