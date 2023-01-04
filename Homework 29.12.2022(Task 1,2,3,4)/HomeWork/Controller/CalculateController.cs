using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Controller
{
    public class CalculateController
    {
        public float Calculate()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Add First Number:");
            Console.ResetColor();
            float n = float.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Add Operation");
            Console.ResetColor();
            string operation = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Add Second Number:");
            Console.ResetColor();
            float m = float.Parse(Console.ReadLine());

            ICalculate calculateService = new Calculate();
            var result = calculateService.Calculate(n, m, operation);
                      
            Console.ForegroundColor= ConsoleColor.Cyan;
            Console.WriteLine($"{result}");
            Console.ResetColor();
           

            return result;

        }
    }
}
