using SinglePageApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinglePageApp.DataRepository
{
    public class CarsRepository
    {
        public static CarContext GetAllCars(CarContext _context)
        {
            if (_context.Car.Local.Count() == 0) {
            _context.Car.Add(new Car() { ID = 1, Brand = "Renault", Model = "Clio" });
            _context.Car.Add(new Car() { ID = 2, Brand = "Citroen", Model = "C5" });
            _context.Car.Add(new Car() { ID = 3, Brand = "Peugeot", Model = "206" });
            };
            return _context;
        }

    }
}
