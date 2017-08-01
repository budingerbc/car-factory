using System;
using System.Collections.Generic;

namespace CarFactory.Models
{
  public class Car
  {
    private int _price;
    private string _manufacturer;
    private string _model;
    private int _mileage;
    private static List<Car> _cars = new List<Car> {};

    public Car (string manufacturer, string model, string price, string mileage)
    {
      _price = int.Parse(price);
      _manufacturer = manufacturer;
      _model = model;
      _mileage = int.Parse(mileage);
    }

    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }
    public int GetPrice()
    {
      return _price;
    }
    public void SetManufacturer(string newManufacturer)
    {
      _manufacturer  = newManufacturer;
    }
    public string GetManufacturer()
    {
      return _manufacturer;
    }
    public void SetModel(string newModel)
    {
      _model = newModel;
    }
    public string GetModel()
    {
      return _model;
    }
    public void SetMileage(int newMileage)
    {
      _mileage = newMileage;
    }
    public int GetMileage()
    {
      return _mileage;
    }

    public static List<Car> GetAllCars()
    {
      return _cars;
    }

    public void Save()
    {
      _cars.Add(this);
    }

  }
}
