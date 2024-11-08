using System.Runtime;

namespace ProxyTask2;

public class RemoteServiceProxy:IRemoteService
{
    private IRemoteService  _cache;
    public void GetData()
    {
        if (_cache is null)
        {
            Console.WriteLine("Getting data from server");
            _cache = new RealRemoteService();
        }
        else
        {
            Console.WriteLine("Getting data from cache");
        }
        _cache.GetData();
    }
}