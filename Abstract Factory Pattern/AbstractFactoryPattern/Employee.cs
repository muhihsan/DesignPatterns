using System;

namespace AbstractFactoryPattern
{
    public abstract class Employee
    {        
        private double Salary { get; set; }
        public abstract double CalculateSalaryBy(int workedHours);
    }
}
