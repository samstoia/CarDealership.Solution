using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic;


namespace CarDealership.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/carlist")]
    public ActionResult CarList(int inputPrice, int inputMiles)
    {
      Car porsche = new Car("2014 Porsche 911", 114991, 7864);
      Car ford = new Car("2011 Ford F450", 55995, 14241);
      Car lexus = new Car("2013 Lexus RX 350", 44700, 20000);
      Car mercedes = new Car("Mercedes Benz CLS550", 39900, 37979);


      List<Car> CarList = new List<Car>() { porsche, ford, lexus, mercedes };

      List<Car> CarsMatchingSearch = new List<Car>();
      foreach(Car car in CarList)
      {
        if(inputPrice>car.GetPrice() && inputMiles>car.GetMiles())
        {
          CarsMatchingSearch.Add(car);
        }
      }

      return View(CarsMatchingSearch);
    }
  }
}
