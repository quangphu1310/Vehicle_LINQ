using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1_LTCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person p1 = new Customer();
            //p1.Input();
            //p1.Output();
            //Console.ReadKey();

            //Person p2= new Employee();
            //p2.Input();
            //p2.Output();
            //Console.ReadKey();

            List<Employee> list = new List<Employee>();
            for(int i = 0; i < 10; i++)
            {
                Employee e = new Employee();
                e.Input();
                list.Add(e);
            }
            foreach (var item in list)
                item.Output();
            
            list = list.OrderBy(x => x.name).ToList();
            Console.WriteLine("Sau khi duoc sap xep: ");
            foreach (var item in list)
                item.Output();
            Console.ReadKey();
        }
    }
}
