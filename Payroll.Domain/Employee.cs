using System.Text.Json;

namespace Payroll.Domain
{
    public class Employee
    {
        public Guid EmployeeId { get; }
        public string Name { get; }
        public int Salary { get; }
        public Employee(Guid employeeId, string name, int salary)
        {
            EmployeeId = employeeId;
            Name = name;
            Salary = salary;
        }
        public Guid GetId()
        {
            return EmployeeId;
        }

        public string ToJson()
        {
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            };
            return JsonSerializer.Serialize(this, options);
        }
    }
}