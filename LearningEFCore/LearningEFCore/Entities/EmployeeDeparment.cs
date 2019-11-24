namespace LearningEFCore.Entities
{
    public class EmployeeDeparment
    {
        public int EmployeeId { get; set; }
        public int DepartmentId { get; set; }
        public Employee Employee { get; set; }
        public Deparment Deparment { get; set; }
    }
}
