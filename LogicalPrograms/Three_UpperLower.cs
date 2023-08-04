using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class Three_UpperLower
    {
        public void Display()
        {
            Console.WriteLine("Enter your favorite place");
            string place=Console.ReadLine();
            string upper=place.ToUpper();
            Console.WriteLine("-------------------------");
            Console.WriteLine("String in Upper Case");
            Console.WriteLine(upper);
            Console.WriteLine("-------------------------");
            string lower =place.ToLower();
            Console.WriteLine("String in Lower Case");
            Console.WriteLine(lower);
        }
    }
}
