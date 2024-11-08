namespace ProxyTask2;

public class RealRemoteService:IRemoteService
{
    public void GetData()
    {
        Console.WriteLine("Connecting to remote service...");
    }
}