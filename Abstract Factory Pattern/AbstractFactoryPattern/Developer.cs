using System;

namespace AbstractFactoryPattern
{
    public class Developer : Employee
    {
        private double Salary { get; set; }        

        public override double CalculateSalaryBy(int workedHours)
        {
            Salary = 500.00;

            return workedHours * Salary;
        }
    }
}
