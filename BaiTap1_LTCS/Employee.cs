using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1_LTCS
{
    public class Employee : Person
    {
        public string degree {  get; set; }
        public Employee() { }
        public Employee(string degree, string name, string address, string email, string phone)
        {
            this.degree = degree;
            this.name = name;
            this.address = address;
            this.email = email;
            this.phone = phone;
        }
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Enter Degree: ");
            this.degree = Console.ReadLine();
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine($"Degree: {this.degree} ");
        }

    }
}
