using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IStudentServices
    {
        int GetStudentsByCount();

        double GetStudentsAge();

        Students[] GetStudentsEmailAndName();

        Students[] GetStudentsAddress();

        Students[] GetStudentNamesSearch(string studName);

        int GetStudentsNamesFiltered();
    }
}
