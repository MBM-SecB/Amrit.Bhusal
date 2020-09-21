public class ABC
{
    public ABC()
    {
         Console.WriteLine("I am born");
     }

    public void A()
    {
        Console.WriteLine("First Method");
    }
    public void B()
    {
        A();
        Console.WriteLine("Second Method");
    }
    public void B(int i)
    {
        Console.WriteLine(i);
        B();
    }
}
class Program
{
    static void Main()
    {
        ABC abc = new ABC();
        abc.B(20);
        abc.A();
    }
}