namespace WPTasks;

class Program
{
    public sealed class Logger
    {
        private static Logger instance;
        
        private Logger(){}
        
        public static Logger Instance()
        {
            if (instance is null)
            {
                instance = new Logger();
            }
            
            return instance;
        }

        public void LoggActivity(string log)
        {
            Console.WriteLine($"Log: {log}");
        }
    }

    static void Main(string[] args)
    {

        Logger l1 =  Logger.Instance();
        Logger l2 = Logger.Instance();
        
        l1.LoggActivity("Log1");
        l2.LoggActivity("Log2");
        
        if(l1==l2)
            Console.WriteLine("This same instance");
        else
            Console.WriteLine("Other Instance");
            
        
    }
}