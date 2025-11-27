using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Vehicle
    {
        public required string Brand { get; set; }

        public int Speed { get; set; }

        public void Start()
        {
            Console.WriteLine($"{Brand} is starting...");
        }

        public void Stop()
        {
            Console.WriteLine($"{Brand} has stopped.");
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Speed: {Speed} km/h");
        }
    }

}
