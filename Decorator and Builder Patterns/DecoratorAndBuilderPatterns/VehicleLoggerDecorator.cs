using System;

namespace DecoratorAndBuilderPatterns
{
    public class VehicleLoggerDecorator : IVehicle
    {
        private readonly IVehicle _vehicle;

        public VehicleLoggerDecorator(IVehicle vehicle, ILogger logger)
        {
            _vehicle = vehicle;
        }

        public void Start()
        {
            Console.WriteLine("Logger before starting vehicle");
            _vehicle.Start();
            Console.WriteLine("Logger after starting vehicle");
        }
    }
}
