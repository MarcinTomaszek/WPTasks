namespace StateTask2;

class Program
{
    static void Main(string[] args)
    {
        var c = new Context();
        
        c.InsertMoney(100);
        c.Start();
        c.Finalize();
        c.InsertMoney(100);
        c.Start();
        c.Finalize();
        c.InsertMoney(1);
        c.Start();
        c.Finalize();


       
        
        

    }
}