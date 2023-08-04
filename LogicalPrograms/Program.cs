using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Enter your CHOICE ");
                Console.WriteLine("-------------------------------------------------------------------------");
                Console.WriteLine("1-Write a program which displays 5 your friends' names");
                Console.WriteLine("2-Program computes the square of sum of these two numbers and square of difference between these 2 numbers. ");
                Console.WriteLine("3-String in Upper and Lower Case");
                Console.WriteLine("4-String Number Display Ten Times");
                Console.WriteLine("5-Split a string and Print words of String");
                Console.WriteLine("6-Print the numbers generated 10-50 in one line and in next line print the average.");
                Console.WriteLine("7-Compute and print out perimeter and area of circle.");
                Console.WriteLine("8-Print next date based on given date");
                Console.WriteLine("9-Display Execution Time");
                Console.WriteLine("-------------------------------------------------------------------------");
                int choice =Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        FriendsName friendsName = new FriendsName();
                        friendsName.Display();
                        Console.WriteLine("-------------------------------------------------------------------------");
                        break;
                    case 2:
                        Two_Square two_Square = new Two_Square();
                        two_Square.Display();
                        Console.WriteLine("-------------------------------------------------------------------------");
                        break;
                    case 3:
                        Three_UpperLower three_UpperLower = new Three_UpperLower();
                        three_UpperLower.Display();
                        Console.WriteLine("-------------------------------------------------------------------------");
                        break;
                    case 4:
                        Four_StringNumber four_StringNumber = new Four_StringNumber();  
                        four_StringNumber.Display();
                        Console.WriteLine("-------------------------------------------------------------------------");
                        break;
                    case 5:
                        Five_FullName five_FullName= new Five_FullName();   
                        five_FullName.Display("Sai Satya Adabala");
                        Console.WriteLine("-------------------------------------------------------------------------");
                        break;
                    case 6:
                        Six_RandomNumber six_RandomNumber = new Six_RandomNumber();
                        six_RandomNumber.Display();
                        Console.WriteLine("-------------------------------------------------------------------------");
                        break;
                    case 7:
                        Seven_Circle seven_Circle = new Seven_Circle();
                        seven_Circle.Display();
                        Console.WriteLine("-------------------------------------------------------------------------");
                        break;
                    case 8:
                        Eight_Date date = new Eight_Date();
                        date.Display();
                        break;
                    case 9:
                        Nine_ExecutionTime nine_ExecutionTime = new Nine_ExecutionTime();
                        nine_ExecutionTime.Run();
                        break;
                    case 10:
                        Ten_Division ten_Division = new Ten_Division();
                        ten_Division.Display();
                        break;
                    default:
                        Console.WriteLine("Enter the Invalide Option");
                        break;
                }

            }
        }
    }
}
