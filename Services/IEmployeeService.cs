using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor344.Models;

namespace Blazor344.Services
{
    public interface IEmployeeService
    {
         Task<IEnumerable<Employee>> GetEmployee();
         Task<Employee> GetEmployee(int id);
    }
}