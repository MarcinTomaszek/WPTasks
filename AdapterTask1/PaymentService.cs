namespace AdapterTask1;

public class PaymentService
{
    public void ProcessPayment(IBankPayment acc)
    {
        if (acc.Amount() <= 0)
        {
            Console.WriteLine("Wrong transaction amount");
            return;
        }
        if (!ValidateBankAccount(acc.BankAccount()))
        {
            Console.WriteLine("Wrong format of account number");
            return;
        }
            
        
        using (var fs = new FileStream(@"..\log", FileMode.Append))
        using (var sw = new StreamWriter(fs))
        {
            sw.WriteLine($"Amount: {acc.Amount()}, AccountNumber: {acc.BankAccount()};");
        }
        
        Console.WriteLine("Payment Processed");
    }

    public bool ValidateBankAccount(string acc)
    {
        if (acc.Length == 28 && acc.Substring(0, 2) == "PL" && acc.Substring(2,26).All(char.IsDigit))
        {
            return true;
        }

        return false;
    }
}