using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada eesja perekonnanimi;
            //programm kontrollib andmete pikkust eraldi
            //programm kuvab kumb nendest on pikem

            Console.WriteLine("Palun sisesta oma eesnimi");
            string firstName = Console.ReadLine();
            int firstNameLenght = firstName.Length;
            Console.WriteLine($"Sinu eesnimes on {firstNameLenght} tähte.");
            Console.WriteLine("Palun sisesta oma perekonnanimi");
            string lastName = Console.ReadLine();
            int lastNameLength = lastName.Length;
            Console.WriteLine($"Sinu eesnimes on {lastNameLength} tähte.");

            if (firstNameLenght > lastNameLength)
            {
                Console.WriteLine("Sinu eesnimi on pikem kui perekonnanimi.");
            }
            else if (firstNameLenght < lastNameLength)
            {
                Console.WriteLine("Sinu perekonnanimi on pikem kui sinu eesnimi.");
            }
            else
            {
                Console.WriteLine("Sinu ees- ja perekonnanimi on sama pikad.");
            }
            

            

        }
    }
}
