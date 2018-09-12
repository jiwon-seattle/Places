using System;
using System.Collections.Generic;

namespace Places.Models
{
  public class Place
  {
    private string _cityName;
    private static List <Place> _instances = new List <Place>{};
    private int _id;

    public Place(string cityName)
    {
      _cityName = cityName;
      _instances.Add(this);
      _id = _instances.Count;
    }

    public int GetId()
    {
      return _id;
    }

    public string GetCityName()
    {
      return _cityName;
    }

    public void SetCityName(string cityName)
    {
      _cityName = cityName;
    }

    public static List <Place> GetInstances()
    {
      return _instances;
    }

    public static Place Find(int id)
    {
      return _instances[id-1];
    }
  }
}
