using System;

namespace color_test
{
    class Program
    {
        enum Color {Yellow = 1, Blue, Green};
            
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hello World! {0}", "Hello to other planets as well!");
        }
    }
}
