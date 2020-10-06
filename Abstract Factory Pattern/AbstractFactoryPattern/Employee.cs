using System;

namespace AbstractFactoryPattern
{
    public class Employee
    {        
        private double Salary { get; set; }
        public virtual double CalculateSalaryBy(int workedHours)
        {
            Salary = 1250.00;

            return workedHours * Salary;
        }
    }
}
