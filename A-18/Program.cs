using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone("Apple", "iPhone 12");
            smartphone.Connect();
            smartphone.Charge(60);
            Console.WriteLine(smartphone.Display());

            Laptop laptop = new Laptop("Dell", "XPS 13");
            laptop.Connect();
            laptop.Charge(120);
            Console.WriteLine(laptop.Display());
        }
    }
    }



