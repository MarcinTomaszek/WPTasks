using System.Data;

namespace ObserverTask1;

public interface IObserver
{
    public void UpdateStatus(float temp, float humi, float press);
}