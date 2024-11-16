using System.Threading.Channels;

namespace ConsoleApp3;

class Program
{
    // анонимные методы
    // простой
    public delegate void D(string s); 
    public static D D1 = delegate (string s)
    {
        Console.WriteLine(s);
    };
    
    // как параметр метода
    static void ShowMessage(string message, MessageHandler handler) // метод
    {
        handler(message);
    }
    delegate void MessageHandler(string message); // делегат

    public static void show(string s)
    {
        Console.WriteLine(s);
    }
    static void Main(string[] args)
    {
        // вызов анонимного метода
        D1("я анонимный метод, вызванный через делегат");
        
        //делегат
        MessageHandler handler = show;
        ShowMessage("пример", handler);
        
        //вызов метода c параметром в виде анонимного метода
        ShowMessage("я анонимный метод, вызванный через делегат без имени в другом методе", delegate (string mes) 
        {
            Console.WriteLine(mes); // анонимный метод 
        });
        
        // другая запись
        ShowMessage("блять что я", mes => Console.WriteLine(mes)); 
        // mes - параметр, => - тело метода, cw - операция
    }
}