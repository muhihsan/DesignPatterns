namespace DesignPatterns.Decorator
{
    public class VehicleValidatorDecorator : IVehicle
    {
        private readonly IVehicle _vehicle;
        private readonly IValidator _validator;

        public VehicleValidatorDecorator(IVehicle vehicle, IValidator validator)
        {
            _vehicle = vehicle;
            _validator = validator;
        }

        public void Start()
        {
            _validator.Validate(_vehicle);

            _vehicle.Start();
        }
    }
}
