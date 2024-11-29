namespace ObserverTask2;

public class MobileAppNotifier:ICurrencyObserver
{
    private Dictionary<string, decimal> curr = new Dictionary<string, decimal>();
    
    public MobileAppNotifier(CurrencyExchange ce)
    {
        ce.RegisterObserver(this);
    }
    public void Update(Dictionary<string, decimal> currencies)
    {
        foreach (var c in currencies)
        {
            curr[c.Key] = c.Value;
        }
    }

    public void DisplayCurrencies()
    {
        Console.WriteLine("Current Rates at Mobile App:");
        foreach (var c in curr)
        {
            Console.WriteLine($"{c.Key}: {c.Value}");
        }
    }
}