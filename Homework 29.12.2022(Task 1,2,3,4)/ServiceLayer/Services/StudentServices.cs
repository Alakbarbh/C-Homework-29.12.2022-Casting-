using DomainLayer.Models;
using ServiceLayer.Helpers;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class StudentServices : IStudentServices
    {
        public Students[] GetStudentNamesSearch(string studentName)
        {   
            Students[] students = All();
            Students[] result = new Students[students.Length];


            int count = 0;
            bool contains = false;
            foreach (var item in students)
            {
                if (item.Name.ToLower() == studentName.ToLower() || item.Surname.ToLower() == studentName.ToLower())
                {
                    result[count] = item;
                    count++;
                    contains = true;

                }

            }

            if (!contains)
            {
                Console.WriteLine(Errors.NameNotFound);
            }

            return result;
        }

        public Students[] GetStudentsAddress()
        {   
            Students[] students = All();
            Students[] result = new Students[students.Length];
            int count = 0;
            bool check = false;
            foreach (var item in students)
            {
                if (item.Address.Contains("Ehmedli"))
                {
                    result[count] = item;
                    count++;
                    check = true;
                }
            }
            if (!check)
            {
                Console.WriteLine(Errors.AddressNotFound);
            }
            return result;
        }

        public double GetStudentsAge()
        {
            Students[] students = All();

            double count = 0;
            foreach (Students item in students)
            {
                count += item.Age;

            }

            return count / students.Length;
        }

        public int GetStudentsByCount()
        {
            var people = All();

            int count = 0;
            foreach (var item in people)
            {
                count++;
            }
            return count;
        }

        public Students[] GetStudentsEmailAndName()
        {
            Students[] students = All();
            Students[] result = new Students[students.Length];

            int count = 0;
            bool check = false;
            foreach (var item in students)

            {
                if (item.Email.StartsWith("C"))
                {
                    result[count] = item;
                    count++;
                    check = true;
                }
            }
            if (!check)
            {
                Console.WriteLine(Errors.EmailNotFound);
            }
            return result;
        }

        public int GetStudentsNamesFiltered()
        {
            var students = All();
            int count = 0;
            foreach (var item in students)
            {
                if (item.Name == "Cavid")
                {
                    count++;

                }
            }
            return count;
        }


        private Students[] All()
        {


            Students stu1 = new Students()
            {
                Id = 1,
                Name = "Cavid",
                Surname = "Ismayilzade",
                Email = "CavidIs123@code.edu.az",
                Age = 23,
                Education = "First education",
                Address = "Dag"
            };

            Students stu2 = new Students()
            {
                Id = 2,
                Name = "Shaig",
                Surname = "Kazimov",
                Email = "Shaig@code.edu.az",
                Age = 25,
                Education = "Bdu education and Code education",
                Address = "Sedmoy"
            };

            Students stu3 = new Students()
            {
                Id = 3,
                Name = "Eycahan",
                Surname = "Colcemenli",
                Email = "Eycahan@code.edu.az",
                Age = 19,
                Education = "First education",
                Address = "Bilinmir"
            };

            Students stu4 = new Students()
            {
                Id = 4,
                Name = "Cahangest",
                Surname = "Veteranli",
                Email = "Cahangest@code.edu.az",
                Age = 26,
                Education = "ADU education and Code education",
                Address = "Ehmedli"
            };

            Students[] people = { stu1, stu2, stu3, stu4 };

            return people;

        }
    }
}

