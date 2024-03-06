using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1_LTCS
{
    public class Customer : Person
    {
        public string type { get; set; }
        public Customer() { }
        public Customer(string type, string name, string address, string email, string phone)
        {
            this.type = type;
            this.name = name;
            this.address = address;
            this.email = email;
            this.phone = phone;
        }
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Enter Type Cusomer: ");
            this.type = Console.ReadLine();
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine($"Type Cusomer: {this.type} ");
        }
    }
}
