using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class Teacher
    {
        public string Name { get; set; } = string.Empty;

        public virtual void Teaching()
        {
            Console.WriteLine("Teacher teaches in English");
        }

        // Cannot be overridden, so just normal method
        public void SalaryInfo()
        {
            Console.WriteLine("Teacher salary is paid monthly.");
        }
    }


}
