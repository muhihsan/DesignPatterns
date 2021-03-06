﻿using System;

namespace DecoratorAndBuilderPatterns
{
    public class VehicleBuilder
    {
        private IVehicle _vehicle;
        private bool _isLoggerAdded;
        private bool _isValidatorAdded;

        private VehicleBuilder()
        {
            _vehicle = new Vehicle();
        }

        public static VehicleBuilder CreateVehicleBuilder()
        {
            return new VehicleBuilder();
        }

        public VehicleBuilder WithLogging(ILogger logger)
        {
            if (_isLoggerAdded)
            {
                throw new Exception("Logger has been added");
            }

            _vehicle = new VehicleLoggerDecorator(_vehicle, logger);
            return this;
        }

        public VehicleBuilder WithValidator(IValidator validator)
        {
            if (_isValidatorAdded)
            {
                throw new Exception("Validator has been added");
            }

            _vehicle = new VehicleValidatorDecorator(_vehicle, validator);
            return this;
        }

        public IVehicle CreateVehicle()
        {
            return _vehicle;
        }
    }
}
