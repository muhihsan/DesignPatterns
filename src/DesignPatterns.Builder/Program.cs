using DesignPatterns.Decorator;

namespace DesignPatterns.Builder
{
    class Program
    {
        public static void Main()
        {
            var vehicle =
                VehicleBuilder.CreateVehicleBuilder()
                .WithLogging(new ConsoleLogger())
                .WithValidator(new Validator())
                .CreateVehicle();

            vehicle.Start();
        }
    }
}
