namespace DecoratorAndBuilderPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicle =
                VehicleBuilder.CreateVehicleBuilder()
                .WithLogging(new Logger())
                .WithValidator(new Validator())
                .CreateVehicle();

            vehicle.Start();
        }
    }
}
