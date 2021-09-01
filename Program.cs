using System;

namespace color_test
{
    class Program
    {
        enum Color {Yellow = 1, Blue, Green};
            
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gree;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Hello World! {0}", "Hello other planets too!");
        }
    }
}
