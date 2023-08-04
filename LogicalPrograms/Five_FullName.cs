using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public  class Five_FullName
    {
        public void Display(string name)
        {
            
            string[] ssr=name.Split(' ');
            int len = ssr.Length;
            Console.WriteLine("Count is "+len);
            Console.WriteLine("------------------------");
            foreach (string s in ssr)
            {
                Console.WriteLine(s);
            }
        }
    }
}
