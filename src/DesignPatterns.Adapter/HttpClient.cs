using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    public class HttpClient : IClient
    {
        private readonly TCP _tcp;

        public HttpClient(TCP tcp)
        {
            _tcp = tcp;
        }

        public Task PostRequest<T>(T payload)
        {
            var bytes = ObjectToByteArray(payload);
            _tcp.SpecificRequest(bytes);

            return Task.CompletedTask;
        }

        private byte[] ObjectToByteArray<T>(T obj)
        {
            if (obj == null)
                return null;

            var bf = new BinaryFormatter();
            using var ms = new MemoryStream();
            bf.Serialize(ms, obj);

            return ms.ToArray();
        }
    }
}
