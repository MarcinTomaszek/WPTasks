namespace ObserverTask2;

public interface ISubject
{
    public void RegisterObserver(ICurrencyObserver obs);
    public void UnregisterObserver(ICurrencyObserver obs);
    public void NotifyObservers();
}