using ServiceLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Controller
{
    public class StudentsController
    {

        private readonly StudentServices _service;

        public StudentsController()
        {
            _service = new StudentServices();
        }

        public void GetStudentByCount()
        {
            Console.WriteLine(_service.GetStudentsByCount());
        }

        public void GetStudentsAge()
        {
            Console.WriteLine(_service.GetStudentsAge());
        }


        public void GetStudentsEmailAndName()
        {
            var result = _service.GetStudentsEmailAndName();
            foreach (var item in result)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.Id} -- {item.Name} -- {item.Surname} -- {item.Email}");
                }

            }
        }

        public void GetStudentsAddress()
        {
            var result = _service.GetStudentsAddress();
            foreach (var item in result)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.Id} -- {item.Name} -- {item.Address}");
                }

            }

        }
        public void GetStudentsNamesFiltered()
        {

            Console.WriteLine(_service.GetStudentsNamesFiltered());
        }





        public void GetStudentNamesSearch()
        {
            Console.WriteLine("ad yazin :");
            string studName = Console.ReadLine();
            var result = _service.GetStudentNamesSearch(studName);

            foreach (var item in result)
            {
                if (item != null)
                {
                    Console.WriteLine($" -- {item.Id} -- {item.Name} -- {item.Surname} -- {item.Education} -- {item.Email} -- {item.Address}");

                }
            }

        }
    }
}
