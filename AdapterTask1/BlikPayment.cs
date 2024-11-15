namespace AdapterTask1;

public class BlikPayment:IMobilePayment
{
    private int _amount;
    private string _phonenumber;

    public BlikPayment(int a, string p)
    {
        _amount = a;
        _phonenumber = p;
    }

    public int Amount()
    {
        return _amount;
    }

    public string PhoneNumber()
    {
        return _phonenumber;
    }

}