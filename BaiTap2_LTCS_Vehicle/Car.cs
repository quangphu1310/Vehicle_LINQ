using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2_LTCS_Vehicle
{
    public class Car : Vehicle
    {
        public static IList<Car> cars
        {
            get
            {
                return new List<Car> {
                    new Car {Id = 1, Name="Honda City", Brand = "Honda", YearOfManufacture = 1990, Price = 80000},
                    new Car {Id = 2, Name="Toyota Camry", Brand= "Toyota", YearOfManufacture = 1880, Price = 210000},
                    new Car {Id = 3, Name = "Honda Civic", Brand= "Toyota", YearOfManufacture = 1990, Price = 300000},
                    new Car {Id = 4, Name="Ford Mustang", Brand = "Ford", YearOfManufacture = 1964, Price = 250000},
                    new Car {Id = 5, Name="Honda Accord", Brand = "Honda", YearOfManufacture = 2005, Price = 150000},
                    new Car {Id = 6, Name="Toyota Corolla", Brand = "Toyota", YearOfManufacture = 2010, Price = 180000},
                    new Car {Id = 7, Name="Ford Focus", Brand = "Ford", YearOfManufacture = 2015, Price = 120000},
                    new Car {Id = 8, Name="Porsche 911", Brand = "Porsche", YearOfManufacture = 2020, Price = 500000},
                };
            }
        }
        
    }
}
