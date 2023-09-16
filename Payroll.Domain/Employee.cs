namespace Payroll.Domain
{
    public class Employee
    {
        private Guid _employeeId;
        private string _name;
        private int _salary;
        public Employee(Guid employeeId, string name, int salary)
        {
            _employeeId = employeeId;
            _name = name;
            _salary = salary;
        }

        public string PrintName()
        {
            return _name;
        }
    }
}