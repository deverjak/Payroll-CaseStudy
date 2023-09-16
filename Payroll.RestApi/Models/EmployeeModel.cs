namespace Payroll.RestApi.Models
{
    public class EmployeeModel
    {
        public Guid EmployeeId { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}