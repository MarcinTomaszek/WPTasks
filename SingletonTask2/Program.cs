using System.IO.Compression;

namespace SingletonTask2;

class Program
{
    public class Logger
    {
        private static Logger instance;
        private static readonly object Lock = new object();
        public string LogMessage { get; set; }
        
        private Logger(){}
        
        public static Logger Instance( string log)
        {
            if (instance is null)
            {
                lock (Lock)
                {
                    if (instance == null)
                    {
                        instance = new Logger();
                        instance.LogMessage = log;
                    }
                        
                }
            }
            
            return instance;
        }
    }

    public static void Test(string val)
    {
        Logger l = Logger.Instance(val);
        Console.WriteLine(l.LogMessage);
    }

    static void Main(string[] args)
    {


        Thread t1 = new Thread(() => Test("Log1"));
        Thread t2 = new Thread(() => Test("Log2"));
        
        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();
        
    }
}