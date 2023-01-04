using DomainLayer.Models;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class EmployeeService : IEmployeeService
    {
        public Employee[] GetEmployee(DateTime maxTime, DateTime minTime)
        {
            Employee[] employees = GetAll();
            Employee[] result = new Employee[employees.Length];
            int count = 0;


            foreach (var item in employees)
            {
                if (item.Birthday > maxTime && item.Birthday < minTime && item.Salary > 2000)
                {
                    result[count] = item;
                    count++;
                }
            }

            return result;
        }



        private Employee[] GetAll()
        {

            Employee employee1 = new Employee()
            {
                Name = "Shaig",
                Surname = "Kazimov",
                Birthday = new DateTime(1991, 10, 10),
                Salary = 1500,
            };
            Employee employee2 = new Employee()
            {
                Name = "Cahangest",
                Surname = "Veteranli",
                Birthday = new DateTime(1997, 09, 01),
                Salary = 2700,
            };
            Employee employee3 = new Employee()
            {
                Name = "Cavid",
                Surname = "Ismayilzade",
                Birthday = new DateTime(1999, 05, 20),
                Salary = 1200,
            };
            Employee employee4 = new Employee()
            {
                Name = "Eycahan",
                Surname = "Colcemenli",
                Birthday = new DateTime(2003, 07, 15),
                Salary = 2001,
            }; Employee employee5 = new Employee()
            {
                Name = "Ferid",
                Surname = "Shakili",
                Birthday = new DateTime(2003, 01, 22),
                Salary = 2002,
            };

            Employee[] people = {employee1,employee2,employee3,employee4,employee5};

            return people;





        }
    }
    
}
