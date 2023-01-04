using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_prac.Casting29._12._2022.Models
{
    internal class Eagle : Bird
    {
        public int Speed { get; set; } = 200;

        public override void Sound()
        {
            Console.WriteLine("Eagle sound");
        }

        public void Test()
        {
            Console.WriteLine("Eagle test");
        }
    }
}
