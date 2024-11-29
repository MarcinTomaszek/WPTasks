namespace ObserverTask1;

public interface ISubject
{
    public void RegisterObserver(IObserver obs);
    public void UnregisterObserver(IObserver obs);
    public void NotifyObservers();
}