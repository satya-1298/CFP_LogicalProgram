using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class Four_StringNumber
    {
        public void Display()
        {
            int num = 10;
            Console.WriteLine("Enter a number");
            string number = Console.ReadLine();
            int len=number.Length;
            Console.WriteLine("Length of String "+len);
            for (int i=1; i<=num; i++)
            {
                Console.WriteLine(i+"-"+number);
            }

        }
    }
}
