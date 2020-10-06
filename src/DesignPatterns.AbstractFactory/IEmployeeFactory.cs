namespace DesignPatterns.AbstractFactory
{
    public interface IEmployeeFactory
    {
        Employee CreateEmployee(EmployeeType employeeType);
    }
}
