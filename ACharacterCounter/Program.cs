﻿using System;

namespace ACharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada ees- ja perekonnanimi
            //programm kuvab, mitu a tähte on kasutaja ees ja prk nimes kokku

            Console.WriteLine("sisesta eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("sisesta perekonnanimi");
            string lastName = Console.ReadLine();
            string fullName = $"{firstName}{lastName}".ToLower();
            
            int aCounter = 0;
            for (int i = 0; i < fullName.Length; i++)
            {
                if (fullName [i] == 'a')
                {
                    aCounter++;
                }
            }
            if (aCounter != 1)
            {
                Console.WriteLine($"Sinu täisnimes on {aCounter} 'a' tähte.");
            }
            else
            {
                Console.WriteLine($"Sinu täisnimes on {aCounter} 'a' täht.");
            }

        }
    }
}
