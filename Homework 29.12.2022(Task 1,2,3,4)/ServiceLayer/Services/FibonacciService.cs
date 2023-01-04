using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class FibonacciService : IFibonacciService
    {
        public void Fibonecci()
        {
            int num1 = 0;
            int num2 = 1;
            int num3;
            int numsElement;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter the Number : ");
            Console.ResetColor();
            numsElement = int.Parse(Console.ReadLine());
            if (numsElement < 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("enter a number two");
                Console.ResetColor();

            }
            else
            {

                Console.WriteLine(num1 + " " + num2 + " ");

                for (int i = 2; i < numsElement; i++)
                {
                    num3 = num1 + num2;
                    Console.Write(num3 + " ");
                    num1 = num2;
                    num2 = num3;
                }
            }
        }
    }
}
