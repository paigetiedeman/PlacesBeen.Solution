using Microsoft.AspNetCore.Mvc;
using PlacesBeen.Models;
using System.Collections.Generic;

namespace PlacesBeen.Controllers
{
  public class PlaceController : Controller
  {
    [HttpGet("/place")]
    public ActionResult Index()
    {
      List<Place> allPlaces = Place.GetAll();
      return View(allPlaces);
    }
    
    [HttpGet("/place/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/place")]
    public ActionResult Create(string cityName)
    {
      Place myPlaces = new Place(cityName);
      return RedirectToAction("Index");
    }
    
    [HttpPost("/place/delete")]
    public ActionResult DeleteAll()
    {
      Place.ClearAll();
      return View();
    }
  }
}