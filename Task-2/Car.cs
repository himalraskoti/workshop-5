using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Car : Vehicle
    {
        public int Seats { get; set; }

        public override void DisplayInfo()
        {
            base.DisplayInfo(); // reuse base class method
            Console.WriteLine($"Seats: {Seats}");
        }
    }

}
