using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Payroll.Domain;

namespace Payroll.Application
{
    public class InMemoryEmployeeRepository : IEmployeeRepository
    {
        public Employee GetEmployee(Guid id)
        {
            return InMemoryDatabase.GetEmployee(id);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            throw new NotImplementedException();
        }

        public void SaveEmployee(Employee employee)
        {
            InMemoryDatabase.AddEmployee(employee.GetId(), employee);
        }
    }
}