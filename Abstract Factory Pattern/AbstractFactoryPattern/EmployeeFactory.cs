using System;

namespace AbstractFactoryPattern
{
    public class EmployeeFactory : IEmployeeFactory
    {
        public Employee CreateEmployee(EmployeeType employeeType) =>
            employeeType switch
            {
               EmployeeType.Employee => new Employee(),               
               EmployeeType.Designer => new Designer(),
               EmployeeType.Developer => new Developer(),
               _ => throw new InvalidOperationException("Invalid Employee type")
            };
    }
}
