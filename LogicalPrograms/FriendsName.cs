using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class FriendsName
    {
        public void Display()
        {
            string[] names = { "Priya", "Ammu", "Puja", "Charan", "Saru" };
            foreach (string name in names)
            { 
                Console.WriteLine(name);
            }
        }
    }
}
