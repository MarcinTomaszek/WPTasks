namespace ProxyTask2;

class Program
{
    static void Main(string[] args)
    {
        var p = new RemoteServiceProxy();
        p.GetData();
        p.GetData();
    }
}