namespace AdapterTask1;

public class SwiftPayment:IBankPayment
{
    private int _amount;
    private string _accnumber;

    public SwiftPayment(int a, string acc)
    {
        _amount = a;
        _accnumber = acc;
    }

    public int Amount()
    {
        return _amount;
    }

    public string BankAccount()
    {
        return _accnumber;
        ;
    }
}