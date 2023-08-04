using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class Ten_Division
    {
        public void Display()
        {
            int count = 0;
            int startRange = 2000;
            int endRange = 3200;
            for (int i = startRange; i <= endRange; i++)
            {
                if(i%7==0 && i%5!=0)
                {
                    count++;

                    Console.WriteLine(count+"-"+i);
                }
            }
        }
    }
}
