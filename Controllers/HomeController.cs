using Microsoft.AspNetCore.Mvc;
using CarFactory.Models;
using System.Collections.Generic;
using System;

namespace CarFactory.Contollers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult AddCar()
    {
      return View();
    }

    [HttpPost("/new-car")]
    public ActionResult ShowNewCar()
    {
      Car newCar = new Car (Request.Form["manufacturer"], Request.Form["model"], Request.Form["price"], Request.Form["mileage"]);
      newCar.Save();
      return View(newCar);
    }

    [Route("/display-cars")]
    public ActionResult CarList()
    {
      List<Car> allCars = Car.GetAllCars();
      return View(allCars);
    }
  }
}
