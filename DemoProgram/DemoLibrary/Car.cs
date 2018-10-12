using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Owner { get; set; }
        public Car(string brand, string model, string owner)
        {
            Brand = brand;
            Model = model;
            Owner = owner;
        }
        public override string ToString()
        {
            return string.Format("{0} {1}, {2}", Brand, Model, Owner);
        }
    }
}
