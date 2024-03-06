using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1_LTCS
{
    public class Person
    {
        public string name { get; set; }
        public string address { get; set; }
        public string email { get; set;}
        public string phone { get; set; }

        public Person()
        {
            
        }
        public Person(string name, string address, string email, string phone)
        {
            this.name = name;
            this.address = address;
            this.email = email;
            this.phone = phone;
        }

        public virtual void Input()
        {
            Console.WriteLine("Enter Name: ");
            this.name = Console.ReadLine();
            Console.WriteLine("Enter Address: ");
            this.address = Console.ReadLine();
            Console.WriteLine("Enter Email: ");
            this.email = Console.ReadLine(); 
            Console.WriteLine("Enter Phone Number: ");
            this.phone = Console.ReadLine();
        }
        public virtual void Output() {
            Console.Write($"Name: {this.name} ");
            Console.Write($"Address: {this.address} ");
            Console.Write($"EMail: {this.email} ");
            Console.Write($"Phone Number: {this.phone} ");
        }
    }
    
}
