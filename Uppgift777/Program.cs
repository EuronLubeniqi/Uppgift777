using System;

class Program
{
    static void Main()
    {
        int nummer;

        Console.WriteLine("Mata in ett positivt tal. Skriv ett negativt tal för att avsluta.");

        while (true)
        {
            Console.Write("Ange ett tal: ");
            nummer = int.Parse(Console.ReadLine());

            if (nummer < 0)
            {
                Console.WriteLine("Du skrev ett negativt tal. Programmet avslutas.");
                break;
            }
        }
    }
}
