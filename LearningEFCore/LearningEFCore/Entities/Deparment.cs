using System.Collections.Generic;

namespace LearningEFCore.Entities
{
    public class Deparment
    {
        public int Id { get; set; }
        public string DeparmentName { get; set; }
        public List<EmployeeDeparment> EmployeeDeparments {get;set;}
    }
}
