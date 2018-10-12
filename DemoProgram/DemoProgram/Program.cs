using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;

namespace DemoProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("Reno", "Grand Scenic 3", "Kitov Sergey Ivanovich");
            Console.WriteLine(car.ToString());
            Console.ReadKey();
        }
    }
}
