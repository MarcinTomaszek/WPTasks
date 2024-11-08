namespace ProxyTask1;

public class RealImage:IImage
{
    private string _filename;
    public RealImage(string name)
    {
        _filename = name;
    }
    public void Display()
    {
        Console.WriteLine($"Loading image {_filename}");
    }
}