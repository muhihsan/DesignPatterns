using System;

namespace DesignPatterns.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var tcp = new TCP();
            var client = new HttpClient(tcp);

            client.PostRequest(new Record(1));
        }
    }
}
