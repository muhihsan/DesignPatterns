using System;

namespace DesignPatterns.Adapter
{
    public class TCP
    {
        public void SpecificRequest(byte[] body)
        {
            Console.WriteLine("Called SpecificRequest()");
        }
    }
}
