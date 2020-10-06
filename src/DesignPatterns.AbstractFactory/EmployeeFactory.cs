using System;

namespace DesignPatterns.AbstractFactory
{
    public class EmployeeFactory : IEmployeeFactory
    {
        public Employee CreateEmployee(EmployeeType employeeType) =>
            employeeType switch
            {             
               EmployeeType.Designer => new Designer(),
               EmployeeType.Developer => new Developer(),
               _ => throw new InvalidOperationException("Invalid Employee type")
            };
    }
}
