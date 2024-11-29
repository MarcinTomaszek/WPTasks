namespace ObserverTask1;

public class MobileDisplay:IObserver
{
    public float temp { get; set; }
    public float humi { get; set; }
    public float press { get; set; }

    public MobileDisplay(WeatherStation w)
    {
        w.RegisterObserver(this);
    }
    public void UpdateStatus(float temp, float humi, float press)
    {
        this.temp = temp;
        this.humi = humi;
        this.press = press;
    }

    public void Display()
    {
        Console.WriteLine("Mobile Display:");
        Console.WriteLine($"Temperature: {temp}");
        Console.WriteLine($"Humidity: {humi}");
        Console.WriteLine($"Pressure: {press}");
    }
}