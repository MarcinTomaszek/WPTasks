namespace AdapterTask1;

public class MobileToBankPaymentAdapter:IBankPayment
{
    private IMobilePayment _mobilePayment;

    public MobileToBankPaymentAdapter(IMobilePayment mp)
    {
        _mobilePayment = mp;
    }
    public int Amount()
    {
        return _mobilePayment.Amount();
    }

    public string BankAccount()
    {
        string res = "PL" + _mobilePayment.PhoneNumber().PadRight(26, '0');
        return res;
    }
}