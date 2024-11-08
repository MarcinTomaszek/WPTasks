namespace ProxyTask3;

public class AccessProxy:IDocument
{
    private User _user;
    
    
    public AccessProxy(User u1)
    {
        _user = u1;
    }
    
    public void ReadContent()
    {
        if (_user.HasAccess)
        {
            var doc = new SecureDocument();
            Console.WriteLine("Getting access");
            doc.ReadContent();
        }
        else
        {
            Console.WriteLine("User don't have access");
        }
    }
}