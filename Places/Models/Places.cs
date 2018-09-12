using System;
using System.Collections.Generic;

namespace Places.Models
{
  public class Place
  {
    private string _cityName;
    private static List <Place> _instances = new List <Place>{};
    private int _id;
    private string _cityDescription;
    private int _cityYear;

    public Place(string cityName, string cityDescription, int cityYear)
    {
      _cityName = cityName;
      _instances.Add(this);
      _id = _instances.Count;
      _cityDescription = cityDescription;
      _cityYear = cityYear;
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

    public string GetCityDescription()
    {
      return _cityDescription;
    }

    public void SetCityDescription(string cityDescription)
    {
      _cityDescription = cityDescription;
    }

    public int GetCityYear()
    {
      return _cityYear;
    }

    public void SetCityYear(int cityYear)
    {
      _cityYear = cityYear;
    }

    public static List <Place> GetInstances()
    {
      return _instances;
    }

    public static Place Find(int id)
    {
      return _instances[id-1];
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
