using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using PlacesBeen.Models;

namespace PlacesBeen.Tests
{
  [TestClass]
  public class PlaceTests
  {
    [TestMethod]
    public void PlaceConstructor_CreatesInstanceOfPlace_Place()
    {
      Place newPlace = new Place("test");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }
    [TestMethod]
    public void GetCityName_ReturnsCityName_String()
    {
      string cityName = "Seattle";
      Place newPlace = new Place(cityName);
      string result = newPlace.CityName;
      Assert.AreEqual(cityName, result);
    }
  }
}