using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    public interface IClient
    {
         Task PostRequest<T>(T payload);
    }
}
