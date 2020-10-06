namespace DesignPatterns.Decorator
{
    class Program
    {
        public static void Main()
        {
            var vehicle = new VehicleValidatorDecorator(new Vehicle(), new Validator());

            vehicle.Start();
        }
    }
}
