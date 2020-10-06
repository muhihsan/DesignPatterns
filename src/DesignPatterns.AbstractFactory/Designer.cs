namespace DesignPatterns.AbstractFactory
{
    public class Designer : Employee
    {
        private double Salary { get; set; }

        public override double CalculateSalaryBy(int workedHours)
        {
            Salary = 3000.00;

            return workedHours * Salary;
        }
    }
}
