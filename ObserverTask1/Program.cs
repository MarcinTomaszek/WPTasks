namespace ObserverTask1;

class Program
{
    static void Main(string[] args)
    {
        WeatherStation w1 = new WeatherStation();
        MobileDisplay md = new MobileDisplay(w1);
        DesktopDisplay dd = new DesktopDisplay(w1);
        w1.UpdateMeasurements(22,40,987);
        md.Display();
        dd.Display();
        w1.UnregisterObserver(md);
        w1.UpdateMeasurements(33,20,999);
        md.Display();
        dd.Display();
    }
}