namespace ProxyTask1;

class Program
{
    static void Main(string[] args)
    {
        IImage image = new ImageProxy("photo.png");
        image.Display();
        image.Display();
    }
}