namespace ObserverTask2;

public interface ICurrencyObserver
{
    public void Update(Dictionary<string,decimal> currencies);
}