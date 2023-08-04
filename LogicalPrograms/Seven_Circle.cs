using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    //Compute perimeter and area of a circle. Take diameter of circle as user input, Compute and print out perimeter and area of circle.
    public class Seven_Circle
    {
        public void Display()
        {
//int radius = 10;
            Console.WriteLine("Enter circle diameter");
            int dia=Convert.ToInt32(Console.ReadLine());
            double area = (Math.PI * dia * dia) / 4;
            double perimeter = (2 * (Math.PI) * dia) / 2;
            Console.WriteLine("Area of circle "+area + "\n" +"Perimeter of circle  " + perimeter);
        }
    }
}
