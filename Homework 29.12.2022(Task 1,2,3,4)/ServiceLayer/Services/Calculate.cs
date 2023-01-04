using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class Calculate : ICalculate
    {
        float ICalculate.Calculate(float n, float m, string operation)
        {
            float result;
            switch (operation)
            {
                case "+":
                    result = n + m;
                    return result;
                case "-":
                    result = n - m;
                    return result;
                case "*":
                    result = n * m;
                    return result;
                case "/":
                    result = n / m;
                    if (m==0)
                    {
                        Console.WriteLine("sifra bolunmur");
                    }
                    return result;
            }
            return default;
        }
    }
}
