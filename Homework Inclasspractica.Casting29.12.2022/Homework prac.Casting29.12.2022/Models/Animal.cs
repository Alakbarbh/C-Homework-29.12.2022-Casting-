using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_prac.Casting29._12._2022.Models
{
    public class Animal
    {
        public string Name { get; set; }
        //public int Speed { get; set; } = 100;

        //public Animal()
        //{
        //    Console.WriteLine("Animal constructor");
        //}
        public void Test()
        {
            Console.WriteLine("Animal test");
        }
        public virtual void Sound()
        {
            Console.WriteLine("Animal sound");
        }
    }
}
