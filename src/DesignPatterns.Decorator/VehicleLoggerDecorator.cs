namespace DesignPatterns.Decorator
{
    public class VehicleLoggerDecorator : IVehicle
    {
        private readonly IVehicle _vehicle;
        private readonly ILogger _logger;

        public VehicleLoggerDecorator(IVehicle vehicle, ILogger logger)
        {
            _vehicle = vehicle;
            _logger = logger;
        }

        public void Start()
        {
            _logger.Info("Logger before starting vehicle");
            _vehicle.Start();
            _logger.Info("Logger after starting vehicle");
        }
    }
}
