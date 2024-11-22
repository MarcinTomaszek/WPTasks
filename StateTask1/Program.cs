namespace StateTask1;

class Program
{
    static void Main(string[] args)
    {
        var c = new Context();
        c.Balance = 100;
        
        c.WithdrawCash(100);
        c.InsertCard();
        c.WithdrawCash(100);
        c.InsertPin("1231");
        c.WithdrawCash(100);
        c.WithdrawCash(100);
        c.InsertPin("1233");
        c.EjectCard();
    }
}