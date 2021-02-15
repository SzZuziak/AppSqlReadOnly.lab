using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace AppSqlReadOnly.Lab.Dal
{
    public class EmployeesRepository : Repository, IEmployeesRepository
    {
        public EmployeesRepository(IDbConnection connection, ISqlQueries sqlQueries)
            : base(connection, sqlQueries, nameof(EmployeesRepository))
        {
        }


        public async Task<IEnumerable<EmployeeDao>> GetAllAsync()
        {
            return await Connection.QueryAsync<EmployeeDao>(GetSqlQuery());
        }
    
        // zad 4
        public async Task<EmployeeDao> GetAsync(int id)
        {
            return await Connection.QueryFirstOrDefaultAsync<EmployeeDao>(GetSqlQuery(), new { EmployeeID = id });
        }

        // zad 4
        public async Task<IEnumerable<EmployeeDao>> GetByCityAsync(string city)
        {
            return await Connection.QueryAsync<EmployeeDao>(GetSqlQuery(), new { City = city });
        }
    }
}
