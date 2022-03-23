using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            string dontPanic = "Don't Panic!";
            dontPanic = dontPanic.Replace('o', '0');
            dontPanic = dontPanic.Replace('a', '4');
            Console.WriteLine(dontPanic);
        }
    }
}
