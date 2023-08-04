using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class Six_RandomNumber
    {
        public void Display()
        {
            Random random = new Random();
            int num = 5, number = 0, sum =0;
            Console.WriteLine("5 random numbers are ");
            for(int i = 0; i < num; i++)
            {
                number=random.Next(10,50); 
                Console.Write("  "+number);
                sum=sum+number;
                
            }
            Console.WriteLine("\n Sum of 5 Random Numbers - "+sum);
            int avg = sum/num;
            Console.WriteLine("\n Average of 5 Random Numbers - "+avg);
        }
    }
}
