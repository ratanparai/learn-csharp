using System;

namespace LearnEventHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            mc.OnComplete += new EventHandler(PrintMessage);
            mc.DoSomeWork();
        }

        private static void PrintMessage(object sender, EventArgs e)
        {
            Console.WriteLine("Event fired!");
            Console.ReadKey();
        }
    }
}