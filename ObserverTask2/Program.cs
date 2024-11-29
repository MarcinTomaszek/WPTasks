namespace ObserverTask2;

class Program
{
    static void Main(string[] args)
    {
        CurrencyExchange ce = new CurrencyExchange();
        DesktopAppNotifier dApp = new DesktopAppNotifier(ce);
        MobileAppNotifier mApp = new MobileAppNotifier(ce);
        ce.NotifyObservers();
        dApp.DisplayCurrencies();
        mApp.DisplayCurrencies();
        ce.UnregisterObserver(mApp);
        ce.UpdateRate("EuroGabka",1.02m);
        ce.NotifyObservers();
        dApp.DisplayCurrencies();
        mApp.DisplayCurrencies();

    }
}