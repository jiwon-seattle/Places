using System;
using System.Collections.Generic;

namespace Places.Models
{
  public class Place
  { 
    public static List<Place> _instances = new List<Place>() {};
    public string CityName { get; set; } 
    public string CityDescription { get; set;}
    public string Companions { get; set; }
    public int Id { get; }
    public Place (string cityName, string cityDescription, string Companions)
    {
      CityName = cityName;
      CityDescription = cityDescription;
      Id = _instances.Count;
      _instances.Add(this);
    }

    public static List<Place> GetAll() {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
    
    public static Place Find(int id)
    {
      return _instances[id-1];
    }
  }
}
