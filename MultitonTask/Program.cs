namespace MultitonTask;

using System;
using System.Collections.Generic;

public class DatabaseConnectionManager
{
    /* Słownik przechowujący instancje połączeń do baz danych*/
    private static readonly Dictionary<string, DatabaseConnectionManager> instances =
        new Dictionary<string, DatabaseConnectionManager>();

    public bool IsConnected { get; private set; }
    public string Database { get; private set; }
    private static readonly object Lock = new object();

    /* Prywatny konstruktor*/
    private DatabaseConnectionManager(string database)
    {
        Database = database;
        IsConnected = false;
    }
    

    /* Metoda zwracająca połączenie do odpowiedniej bazy danych*/
    public static DatabaseConnectionManager GetConnection(string database)
    {
        lock (Lock)
        {
            if (!instances.ContainsKey(database))
            {
                instances[database] = new DatabaseConnectionManager(database);
            }
            return instances[database];
        }
    }

    // Otwieranie połączenia
    public void OpenConnection()
    {
        if (IsConnected==false)
        {
            Console.WriteLine($"Opening database {Database}");
            IsConnected = true;
        }
        else
        {
            Console.WriteLine($"{Database} already opened");
        }
    }

    // Zamykanie połączenia
    public void CloseConnection()
    {
        if (IsConnected==true)
        {
            Console.WriteLine($"Closing database {Database}");
            IsConnected = false;
        }
        else
        {
            Console.WriteLine($"{Database} already closed");
        }
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Database name: {Database}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var c1 = DatabaseConnectionManager.GetConnection("db1");
        var c2 = DatabaseConnectionManager.GetConnection("db2");
        var c3 = DatabaseConnectionManager.GetConnection("db1");
        
        c1.OpenConnection();
        c2.OpenConnection();
        c3.OpenConnection();
        
        c1.CloseConnection();
        c2.CloseConnection();
        c3.CloseConnection();
    }
}
