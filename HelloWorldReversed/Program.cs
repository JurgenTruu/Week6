using System;

namespace HelloWorldReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta lause Hello World!");
            string Lause = Console.ReadLine();
            for (int i = Lause.Length - 1; i >= 0; i--)
            {
                Console.Write(Lause[i]);
            }

        }
    }
}
