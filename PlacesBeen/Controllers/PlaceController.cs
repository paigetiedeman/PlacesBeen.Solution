using Microsoft.AspNetCore.Mvc;
using PlacesBeen.Models;
using System.Collections.Generic;

namespace PlacesBeen.Controllers
{
  public class PlaceController : Controller
  {
    [HttpGet("/project")]
    public ActionResult Index()
    {
      return View();
    }
    
    [HttpGet("/project/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/project")]
    public ActionResult Create()
    {
      // Packer myItems = new Packer(items);
      return RedirectToAction("Index");
    }
  }
}