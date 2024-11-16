namespace ConsoleApp2;

class Program
{
    public delegate int del(int a, int b);
    
    public static int Func(int a, int b, del d)
    {
        return d(a, b);
    }
    
    int Add(int x, int y) => x + y;
    int Subtract(int x, int y) => x - y;
    int Multiply(int x, int y) => x * y;
    
    static void Main(string[] args)
    {
        del? d;
    }
}