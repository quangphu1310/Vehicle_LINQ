using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2_LTCS_Vehicle
{
    public class Truck : Vehicle
    {
        public string holdingCompany {  get; set; }
        public static IList<Truck> trucks
        {
            get
            {
                return new List<Truck>
                {
                    new Truck {Id = 1, Name = "Volvo Truck", Brand = "Volvo", YearOfManufacture = 1990, Price = 80000, holdingCompany = "Volvo"},
                    new Truck {Id = 2, Name = "Scania Truck", Brand = "Scania", YearOfManufacture = 1880, Price = 210000, holdingCompany = "Scania"},
                    new Truck {Id = 3, Name = "Mercedes-Benz Truck", Brand = "Mercedes-Benz", YearOfManufacture = 2005, Price = 150000, holdingCompany = "Mercedes-Benz"},
                    new Truck {Id = 4, Name = "MAN Truck", Brand = "MAN", YearOfManufacture = 2010, Price = 120000, holdingCompany = "MAN"},
                    new Truck {Id = 5, Name = "Iveco Truck", Brand = "Iveco", YearOfManufacture = 2015, Price = 180000, holdingCompany = "Iveco"}
                };
            }
        }
    }
}
