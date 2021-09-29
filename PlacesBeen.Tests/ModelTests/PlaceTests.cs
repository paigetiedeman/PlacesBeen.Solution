using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using PlacesBeen.Models;

namespace PlacesBeen.Tests
{
  [TestClass]
  public class PlaceTests : IDisposable
  {
    public void Dispose()
    {
      Place.ClearAll();
    }

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
    [TestMethod]
    public void SetCityName_SetCityName_String()
    {
      string cityName = "Seattle";
      Place newPlace = new Place(cityName);
      string cityName2 = "Chicago";
      newPlace.CityName = cityName2;
      string result = newPlace.CityName;
      Assert.AreEqual(cityName2, result);
  }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_PlaceList()
    {
      List<Place> newList = new List<Place> {};
      List<Place> result = Place.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

  }
}