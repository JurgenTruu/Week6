using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis mitu h, o, l tähte on lauses "Hello World!"
            Console.WriteLine("Kirjuta lause Hello World!");
            string Lause = Console.ReadLine().ToLower();
            int hCounter = 0;
            for (int i = 0; i < Lause.Length; i++)
            {
                if(Lause[i] == 'h')
                {
                    hCounter++;
                }
            }
            int oCounter = 0;
            for (int i = 0; i < Lause.Length; i++)
            {
                if (Lause[i] == 'o')
                {
                    oCounter++;
                }
            }
            int lCounter = 0;
            for (int i = 0; i < Lause.Length; i++)
            {
                if (Lause[i] == 'l')
                {
                    lCounter++;
                }
            }
            Console.WriteLine($"Lauses Hello World! on {hCounter} 'h' täht, {oCounter} 'o' tähte ja {lCounter} 'l' tähte.");
        }
    }
}
