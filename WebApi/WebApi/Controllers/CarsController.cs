using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController
    {
        List<Car> CarData;

        public CarsController()
        {
            CarData = new List<Car>();
            CarData.Add(new Car { Id = 1, Brand = "Mercedes", Model = "S600" });
            CarData.Add(new Car { Id = 2, Brand = "Volvo", Model = "245" });
            CarData.Add(new Car { Id = 3, Brand = "SAAB", Model = "9000" });
            CarData.Add(new Car { Id = 4, Brand = "Audi", Model = "A6" });
            CarData.Add(new Car { Id = 5, Brand = "BMW", Model = "650" });
            CarData.Add(new Car { Id = 6, Brand = "Citroen", Model = "DS5" });
            CarData.Add(new Car { Id = 7, Brand = "Mercedes", Model = "SL500" });
            CarData.Add(new Car { Id = 8, Brand = "BMW", Model = "M5" });
            CarData.Add(new Car { Id = 9, Brand = "Porsche", Model = "S4 Carrera" });
            CarData.Add(new Car { Id = 10, Brand = "Lexus", Model = "400" });
            CarData.Add(new Car { Id = 11, Brand = "Toyota", Model = "Corolla" });
        }


        [HttpGet]
        public List<Car> Index()
        {
            return CarData;
        }

        [HttpGet]
        [Route("/getcar/{id}")]
        public Car GetCar(int id)
        {
            Car Car = CarData.FirstOrDefault(x => x.Id == id); //Lamda expession (x => x.Id == id)
            return Car;
        }
    }
}
