using System;
using System.Collections.Generic;

public class Car
{
  private int _price;
  private string _manufacturer;
  private string _model;
  private int _mileage;

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
}

public class Program
{
  public static void Main()
  {
    Car porche = new Car();
    porche.SetPrice(114991);
    porche.SetManufacturer("Porche");
    porche.SetModel("2014 Porsche 911");
    porche.SetMileage(111000);

    Car ford = new Car();
    ford.SetPrice(55995);
    ford.SetManufacturer("Ford");
    ford.SetModel("2011 Ford F450");
    ford.SetMileage(999888);

    Car lexus = new Car();
    lexus.SetPrice(79875);
    lexus.SetManufacturer("Lexus");
    lexus.SetModel("2010 Lexus L20");
    lexus.SetMileage(44111);

    List<Car> list = new List<Car>() {porche, ford, lexus};
    foreach(Car c in list)
    {
      if (c.GetPrice() < 80000 && c.GetMileage() < 60000)
      {
        filteredList.Add(c);
      }
    }
    
    List<Car> filteredList = new List<Car>();
    foreach(Car d in filteredList)
    {
      Console.WriteLine("Drive home today this beautiful " + d.GetModel());
      Console.WriteLine("It is only $" + d.GetPrice() + ".");
      Console.WriteLine("These are bargain prices!");
      Console.WriteLine("Your friends will be envious of this " + d.GetManufacturer() + ".");
    }
  }
}
