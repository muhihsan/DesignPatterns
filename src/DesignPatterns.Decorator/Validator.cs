using System;

namespace DesignPatterns.Decorator
{
    public class Validator : IValidator
    {
        public void Validate(IVehicle vehicle)
        {
            if (false)
            {
                throw new Exception();
            }
        }
    }
}
