namespace ObserverTask2;

public class CurrencyExchange:ISubject
{
    private Dictionary<string, decimal> _currencies = new Dictionary<string, decimal>()
    {
        { "EUR", 4.40m },
        { "USD", 4.30m },
        { "GBP", 4.90m },
    };
    public List<ICurrencyObserver> obsList = new List<ICurrencyObserver>();
    
    public void RegisterObserver(ICurrencyObserver obs)
    {
        Console.WriteLine("Observer attached");
        obsList.Add(obs);
    }

    public void UnregisterObserver(ICurrencyObserver obs)
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
            o.Update(_currencies);
        }
        Console.WriteLine("All observers notified");
    }

    public void UpdateRate(string curr, decimal rate)
    {
        if (_currencies.ContainsKey(curr))
        {
            Console.WriteLine($"Currency {curr} updated");
            _currencies[curr] = rate;
        }
        else
        {
            _currencies[curr] = rate;
            Console.WriteLine($"Currency {curr} added");
        }
        
        NotifyObservers();
    }
}