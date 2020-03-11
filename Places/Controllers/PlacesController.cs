using Microsoft.AspNetCore.Mvc;
using Places.Models;
using System;
using System.Collections.Generic;

namespace Places.Controllers
{
  public class PlacesController : Controller
  {
    [HttpGet("/places")]
    public ActionResult Index()
    {
      //Displays list of places
      List<Place> allPlaces = Place.GetAll();
      return View(allPlaces);
    }

    [HttpGet("/places/new")]
    public ActionResult New()
    {
      //Offers form to create new place
      return View();
    }

    [HttpPost("/places")]
    public ActionResult Create(string cityName, string cityDescription, string companions)
    {
      //Creates new place
      Place myPlace = new Place(cityName, cityDescription, companions);
      return RedirectToAction("Index", myPlace);
    }

    [HttpPost("/places/delete")]
    public ActionResult DeleteAll()
    {
      //Clears all places
      Place.ClearAll();
      return View();
    }

    [HttpGet("/places/{id}")]
    public ActionResult Show(int id)
    {
      //Displays one place's specific details
      Place selectedPlace = Place.Find(id);
      return View(selectedPlace);
    }
   
  }
}
