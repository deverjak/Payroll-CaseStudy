using System.Collections;
using Payroll.Domain;

namespace Payroll.Application
{
    public class InMemoryDatabase
    {
        private static readonly Hashtable employees = new Hashtable();
        public static void AddEmployee(Guid id, Employee employee)
        {
            employees.Add(id, employee);
        }
        public static Employee GetEmployee(Guid id)
        {
            return employees[id] as Employee;
        }
    }
}