namespace ObserverTask1;

public class WeatherStation:ISubject
{
    public List<IObserver> obsList = new List<IObserver>();
    public float temp { get; set; }
    public float humi { get; set; }
    public float press { get; set; }

    public void RegisterObserver(IObserver obs)
    {
        Console.WriteLine("Observer attached");
        obsList.Add(obs);
    }

    public void UnregisterObserver(IObserver obs)
    {
        if (obsList.Contains(obs))
        {
            obsList.Remove(obs);
            Console.WriteLine("Observer detached");
        }
        else
        {
            Console.WriteLine("Observer not found");
        }
        
    }

    public void NotifyObservers()
    {
        foreach (var o in obsList)
        {
            o.UpdateStatus(temp,humi,press);
        }
        Console.WriteLine("All observers notified");
    }

    public void UpdateMeasurements(float temperature, float humidity, float pressure)
    {
        temp = temperature;
        humi = humidity;
        press = pressure;
        NotifyObservers();
        Console.WriteLine("Measurements updated");
    }
}