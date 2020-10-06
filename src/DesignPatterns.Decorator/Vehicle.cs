using System;

namespace DesignPatterns.Decorator
{
    public class Vehicle : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Starting vehicle");
        }
    }
}
