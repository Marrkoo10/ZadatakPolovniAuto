using Microsoft.AspNetCore.Mvc;
using ZadatakPolovniAuto.Models;
using System.Linq;

namespace ZadatakPolovniAuto.Controllers
{
    public class CarController : Controller
    {
        private static List<Car> cars = new List<Car>
        {
            new Car { Marka = "Marka1", Model = "Model1", Godiste = 2020, Cena = 15000 },
            new Car { Marka = "Marka2", Model = "Model2", Godiste = 2018, Cena = 12000 },
        };

        public IActionResult Index()
        {
            return View(cars);
        }

        public IActionResult Details(int id)
        {
            Car car = cars.FirstOrDefault(c => c.Id == id);
            if (car == null)
            {
                return NotFound();
            }
            return View(car);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Car newCar)
        {
            
            newCar.Id = cars.Count + 1;

            cars.Add(newCar); 
            return RedirectToAction("Index");
        }
    }
}
