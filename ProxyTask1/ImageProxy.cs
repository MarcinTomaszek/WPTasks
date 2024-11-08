namespace ProxyTask1;

public class ImageProxy:IImage
{
    private RealImage _ri;
    private string _filename;

    public ImageProxy(string name)
    {
        _filename = name;
    }
    
    public void Display()
    {
        if (_ri is null)
        {
            Console.WriteLine("Initializing real image");
            _ri = new RealImage(_filename);
        }
        Console.WriteLine("Taking from proxy");
        _ri.Display();
    }
}