using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp1;

class Program
{ 
    // метод с лямбда-оператором
    //public static int Sum(int a, int b) => a + b;

    public static int Sum(int a, int b)
    {
        return a + b;
    }
    public static int Sub(int a, int b) => a - b;
    // делегат - тип, указывающий на метод
    delegate int SumDelegate(int a, int b);
    
    static void Main(string[] args)
    {
        // стандартный вызов метода
        Console.WriteLine(Sum(1,2));
        
        // создание экземпляра делегата c указанием метода через конструктор
        SumDelegate s1 = new SumDelegate(Sum);
        // создание экземпляра делегата через присваивание
        SumDelegate s2 = Sum;
        
        // вызов делегата как метода
        Console.WriteLine(s1(1,2));
        // вызов делегата через Invoke
        Console.WriteLine(s1.Invoke(1,2));
        
        // создание пустого делегата
        SumDelegate? s3;
        // присвоение метода делегату
        s3 = Sum;
        // добавление ещё одного метода в делегат
        s3 += Sub; // s3 = s3 + Sub
        // вызов делегата с множеством методов
        var result = s3(1,2);
        Console.WriteLine(result);
        // возвращаемым значением делегата с множеством
        // методов будет возвращаемое значение последнего
        // вызванного метода
        
        // удаление метода из делегата
        s3 -= Sub;
        // проверка на существование других методов в делегате
        if (s3 != null)
            Console.WriteLine(s3(1,2));
        
        // объединение делегатов 
        SumDelegate s4 = s1 + s2;
        
        // вызов пустого делегата 
        SumDelegate? s = Sum;
        s -= Sum;
        int? r = s?.Invoke(1,2); 
        
    }
    
}