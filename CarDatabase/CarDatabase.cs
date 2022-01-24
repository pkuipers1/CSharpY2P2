using System;
using System.Collections.Generic;
using System.Text;

namespace CarDatabase
{
    class CarDatabase
    {
        List<Car> cars;

        public CarDatabase()
        {
            cars = new List<Car>();
        }

        public void AddCar(Car aCar)
        {
            cars.Add(aCar);
        }

        public List<Car> GetCars()
        {
            return cars;
        }
    }
}
