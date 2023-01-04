using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IEmployeeService
    {
        Employee[] GetEmployee(DateTime maxTime, DateTime minTime);

    }
}

