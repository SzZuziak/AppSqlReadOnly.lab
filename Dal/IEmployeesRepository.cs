using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSqlReadOnly.Lab.Dal
{
    public interface IEmployeesRepository
    {
        Task<IEnumerable<EmployeeDao>> GetAllAsync();
        Task<EmployeeDao> GetAsync(int id);
        Task<IEnumerable<EmployeeDao>> GetByCityAsync(string city);
       

    }
}
