namespace AdapterTask2;

class Program
{
    static void Main(string[] args)
    {
        JpegImage jpg = new JpegImage();
        PngImage png = new PngImage();
        GifHandler gif = new GifHandler();
        GifImageAdapter agif = new GifImageAdapter(gif);
        
        jpg.Load("jpgFile");
        png.Load("pngFile");
        agif.Load("gifFile");
        jpg.Display();
        png.Display();
        agif.Display();
    }
}