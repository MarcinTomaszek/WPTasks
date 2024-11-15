namespace AdapterTask1;

class Program
{
    static void Main(string[] args)
    {
        SwiftPayment sp = new SwiftPayment(1200, "PL12345678901234567890123456");
        SwiftPayment sp0 = new SwiftPayment(1200, "PL85726318901234512351234562");
        SwiftPayment sp1 = new SwiftPayment(1200, "PL12345678901234567456");
        SwiftPayment sp2 = new SwiftPayment(-1200, "PL12345678901234567890123456");

        PaymentService ps = new PaymentService();
        
        ps.ProcessPayment(sp);
        ps.ProcessPayment(sp0);
        ps.ProcessPayment(sp1);
        ps.ProcessPayment(sp2);

        BlikPayment b1 = new BlikPayment(1000, "123123123");
        BlikPayment b2 = new BlikPayment(1200, "123523673");
        BlikPayment b3 = new BlikPayment(0, "123523673");
        
        ps.ProcessPayment(new MobileToBankPaymentAdapter(b1));
        ps.ProcessPayment(new MobileToBankPaymentAdapter(b2));
        ps.ProcessPayment(new MobileToBankPaymentAdapter(b3));
       
    }
}