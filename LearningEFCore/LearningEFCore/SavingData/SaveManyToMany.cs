using LearningEFCore.Entities;
using LearningEFCore.Infrastructure;
using System;
using System.Linq;

namespace LearningEFCore.SavingData
{
    public class SaveManyToMany
    {
        public static void Run()
        {
            var _db = new MyContext();
            var deparment = new Deparment
            {
                DeparmentName = "Deparment"
            };

            var employee1 = new Employee
            {
                EmployeeName = "employee1"
            };

            var employee2 = new Employee
            {
                EmployeeName = "employee2"
            };

            var employeeDeparment1 = new EmployeeDeparment
            {
                Employee = employee1,
                Deparment = deparment
            };

            var employeeDeparment2 = new EmployeeDeparment
            {
                Employee = employee2,
                Deparment = deparment
            };

            _db.Add(employeeDeparment1);
            _db.Add(employeeDeparment2);
            _db.SaveChanges();

            var employees = _db.Employee.ToList();

            foreach(var employee in employees)
            {
                Console.WriteLine(employee.EmployeeName);
            }

            Console.ReadLine();
        }
    }
}
