using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class Two_Square
    {
        public void Display()
        {
            Console.WriteLine("Enter First Value");
            decimal val_One=Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter Second Value");
            decimal val_Two=Convert.ToDecimal(Console.ReadLine());    
            decimal sum=val_One+val_Two; 
            decimal sumval=sum*sum;
            decimal sub=val_One-val_Two;
            decimal subval = sub * sub;
            Console.WriteLine(" Difference of Two values Square of {0} - {1} = {2}  ",val_One,val_Two,sub+" is  "+subval);
            Console.WriteLine("Sum of Two values Square of {0} + {1} = {2}  ", val_One, val_Two, sum + " is  " + sumval);

        }
    }
}
