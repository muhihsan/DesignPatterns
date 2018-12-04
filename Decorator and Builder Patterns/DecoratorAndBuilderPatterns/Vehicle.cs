using System;

namespace DecoratorAndBuilderPatterns
{
    public class Vehicle : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Starting vehicle");
        }
    }
}
