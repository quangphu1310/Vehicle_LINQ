using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2_LTCS_Vehicle
{
    public class Vehicle
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public int YearOfManufacture { get; set; }
        public double Price { get; set; }

        public string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3} - {4}", Id, Name, Brand, YearOfManufacture, Price);
        }
        
    }
}
