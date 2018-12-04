using System;

namespace DecoratorAndBuilderPatterns
{
    public class VehicleValidatorDecorator : IVehicle
    {
        private readonly IVehicle _vehicle;

        public VehicleValidatorDecorator(IVehicle vehicle, IValidator validator)
        {
            _vehicle = vehicle;
        }

        public void Start()
        {
            Console.WriteLine("Validator before starting vehicle");
            _vehicle.Start();
            Console.WriteLine("Validator after starting vehicle");
        }
    }
}
