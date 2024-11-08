namespace ProxyTask3;

class Program
{
    static void Main(string[] args)
    {
        User u1 = new User() { HasAccess = true };
        User u2 = new User() { HasAccess = false };

        AccessProxy a1 = new AccessProxy(u1);
        a1.ReadContent();
        
        Console.WriteLine();
        AccessProxy a2 = new AccessProxy(u2);
        a2.ReadContent();
    }
}