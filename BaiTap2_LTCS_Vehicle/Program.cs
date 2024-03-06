using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2_LTCS_Vehicle
{
    internal class Program
    {
        static void OutputTruck(List<Truck> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();

        }
        static void OutputCar(List<Car> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();

        }
        static void Main(string[] args)
        {
            //Car car = new Car();
            //hiển thị các xe có giá trong khoảng 100.000 đến 250.000
            var cars = Car.cars;
            Console.WriteLine("Bai 1:");
            Console.WriteLine("Cau a:");
            List<Car> listA = cars.Where(c => c.Price >= 100000 && c.Price <= 250000).ToList();
            OutputCar(listA);
            //các xe có năm sản xuất > 1990.
            Console.WriteLine("Cau b:");
            var listB = cars.Where(c => c.YearOfManufacture > 1990).ToList();
            OutputCar(listB);

            //gom các xe theo hãng sản xuất, tính tổng giá trị theo nhóm
            Console.WriteLine("Cau c:");
            var listC = cars.GroupBy(x => x.Brand).ToList();
            foreach (var car in listC)
            {
                Console.WriteLine($"{car.Key} {car.Sum(x => x.Price)}");
            }
            Console.ReadKey();

            Console.WriteLine("Bai 2:");
            //hiển thị danh sách Truck theo thứ tự năm sản xuất mới nhất
            Console.WriteLine("Cau a:");
            var trucks = Truck.trucks;
            var listD = trucks.OrderByDescending(x => x.YearOfManufacture).ToList();
            OutputTruck(listD);

            //hiển thị tên cty chủ quản của Truck
            Console.WriteLine("Cau b:");
            var listE = trucks.Select(x => x.holdingCompany).ToList();
            foreach (var item in listE)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
