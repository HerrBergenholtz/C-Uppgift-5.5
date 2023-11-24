using System;

class Program
{
    public static void Main()
    {
        string[] magiskaSvar = {
            "Absolut!", "Fårga Ameen", "Fråga David", "Detta är INTE semantiskt korrekt",
            "Detta är inte en bra idé", "Dålig idé", "NEJ", "JA", "Kanske", "Vad skulle Ameen tycka?"
        };
        bool running = true;
        
        try
        {
            while (running)
            {
                Console.WriteLine("Ställ en fråga till den magiska 8-bollen,,, eller skriv \"a\" för att Avsluta");
                string svar = Console.ReadLine();
            
                if (svar == "a")
                {
                    running = false;
                }
                else
                {
                    Random slump = new Random();
                    Console.WriteLine(magiskaSvar[slump.Next(10)]);
                    Console.WriteLine("");
                }
            }
            Console.WriteLine("Välkommen åter");
            Console.ReadKey();
        }

        catch
        {
            Console.WriteLine("8-Bollen accepterar inte din input, vänligen försök igen");
            Main();
        }
    }
}