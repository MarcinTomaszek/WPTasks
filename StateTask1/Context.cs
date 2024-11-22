namespace StateTask1;

public class Context
{
    private State _state ;
    private decimal _balance;

    public decimal Balance
    {
        get => _balance;
        set { _balance = value; }
    }

    public Context()
    {
        _state = new NoCard(this);
    }
    public void ChangeState(State s)
    {
        _state = s;
    }

    public void InsertCard()
    {
        _state.InsertCard();
    }

    public void EjectCard()
    {
        _state.EjectCard();
    }

    public void InsertPin(string pin)
    {
        _state.InsertPin(pin);
    }

    public void WithdrawCash(int amount)
    {
        _state.WithdrawCash(amount);
    }
}