using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Places.Models;

namespace Places.Tests
{
    [TestClass]
    public class PlaceTests : IDisposable
  {
    public void Dispose()
    {
        // Teardown - reset data after every test
        Place.ClearAll();
    }
    

    [TestMethod]
    public void PlaceConstructor_CreatePlace_Place()
    {
        Place place = new Place("cityName", "cityDescription", "companions");
        Assert.AreEqual("cityName", place.CityName);
        Assert.AreEqual("cityDescription", place.CityDescription);
        Assert.AreEqual("companions", place.Companions);
        Assert.AreEqual(typeof(Place), place.GetType());
    }


    [TestMethod]
    public void GetId_GetFirstPlace_FirstPlace()
    {
        //Arrange
        string cityName = "Shanghai";
        string cityDescription = "Too crowded but mordern city";
        string companions = "Friends";
        Place place = new Place(cityName, cityDescription, companions);

        //Act
        int result = place.Id;
        
        //Assert
        Assert.AreEqual(1, result);
        
    }
    
    [TestMethod]
    public void GetAll_ReturnsEmptyList_PlaceList()
    {
        List<Place> emptyList = new List<Place> { };
        List<Place> result = Place.GetAll();
        CollectionAssert.AreEqual(emptyList, result);
    }
        
        
    [TestMethod]
    public void GetAll_GetAllTheCitiesInTheList_AllCities()
    {
        //Arrange
        string cityName = "Shanghai";
        string cityDescription = "Too crowded but mordern city";
        string companions = "Friends";
        Place place = new Place(cityName, cityDescription, companions);

        string cityName2 = "Singapore";
        string cityDescription2 = "Very clean and chinese indian city";
        string companions2 = "Friends";
        Place place2 = new Place(cityName2, cityDescription2, companions2);
        
        //Act
        List<Place> AllCities = new List<Place> { place, place2 };
        
        //Assert 
        
        CollectionAssert.AreEqual(AllCities, Place.GetAll());
    }

    [TestMethod]
    public void Find_FindSpecificPlace_Place()
    {
        //Arrange
        string cityName = "Shanghai";
        string cityDescription = "Too crowded but mordern city";
        string companions = "Friends";
        Place place = new Place(cityName, cityDescription, companions);

        string cityName2 = "Singapore";
        string cityDescription2 = "Very clean and chinese indian city";
        string companions2 = "Friends";
        Place place2 = new Place(cityName2, cityDescription2, companions2);
        
        //Act
        Place result = Place.Find(2);
        
        //Assert 
        Assert.AreEqual(place2, result);
    }
  }
}
