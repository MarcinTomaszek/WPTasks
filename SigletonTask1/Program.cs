namespace WPTasks;

class Program
{
    public class Logger
    {
        private static Logger instance;
        
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
            
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}