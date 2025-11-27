using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Motorcycle : Vehicle
    {
        public bool HasCarrier { get; set; }

        public override void DisplayInfo()
        {
            base.DisplayInfo(); // reuse base class
            Console.WriteLine($"Has Carrier: {HasCarrier}");
        }
    }

}
