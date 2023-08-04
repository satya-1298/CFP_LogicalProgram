using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    //"Develop  a program to get next day of a given date. 
    //    Expected Output:
    //Input a year: 2020                                                     
    //Input a month[1 - 12]: 08                                                
    //Input a day[1 - 31]: 23                                                  
    //The next date is [yyyy-mm-dd] 2020-8-24   "
    public class Eight_Date
    {
        public void Display()
        {

            Console.WriteLine("Enter the Month");
            int mm=Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine("Enter the year");
            int yyyy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the day");
            int dd = Convert.ToInt32(Console.ReadLine());
            DateTime dateTime =new DateTime(yyyy,mm,dd);
            Console.WriteLine(dateTime);
            DateTime date = dateTime.AddDays(1);
           // Console.WriteLine(date.Date.ToString("[yyyy-mm-dd]"));
            Console.WriteLine(date);
           
        }
    }
}
