using System.Threading.Channels;
using Microsoft.VisualBasic;

namespace ConsoleApp4;

class Program
{
    public delegate void d(int a, int b);

    public static int Summ(int[] numbers, Compare f)
    {
        var r = 0;
        foreach (int i in numbers)
            if (f(i))
                r += i;
        return r;
    }
    public delegate bool Compare(int x);
    static void Main(string[] args)
    {
        // лямбда с параметрами через делегат
        d sum = (a, b) => Console.WriteLine(a+b);
        sum(10, 20);
        // лямбда с динамической типизацией
        var sum2 = (int a, int b) => Console.WriteLine(a+b);
        sum2(10, 20);
        // лямбда как параметр метода
        int [] n = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        // явный делегат
        Compare c = delegate(int x)
        {
            return x > 5;
        };
        Console.WriteLine(Summ(n, c));
        // лямбда
        Console.WriteLine(Summ(n, x => x > 5));
    }
}