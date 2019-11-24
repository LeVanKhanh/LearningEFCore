using System.Collections.Generic;

namespace LearningEFCore.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public List<EmployeeDeparment> EmployeeDeparments { get; set; }
    }
}
