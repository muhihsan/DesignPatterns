using System;

namespace AbstractFactoryPattern
{
    public interface IEmployeeFactory
    {
        Employee CreateEmployee(EmployeeType employeeType);
    }
}
