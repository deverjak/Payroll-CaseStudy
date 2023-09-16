using Payroll.Domain;

namespace Payroll.Application
{
    public interface IEmployeeRepository
    {
        void SaveEmployee(Employee employee);
        Employee GetEmployee(Guid id);
        IEnumerable<Employee> GetEmployees();
    }
}