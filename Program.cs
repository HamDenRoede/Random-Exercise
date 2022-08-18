using System;

namespace RandomExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning();
            sixCount();
        }

        static void Terning()
        {
            Random value = new Random();
            
            for (int i = 1; i <= 10; i++)
            {
                int terning = value.Next(1, 7);
                Console.WriteLine(terning);
            }
            Console.WriteLine("Done with 10 dice \n");
        }

        static void sixCount()
        {
            Random value = new Random();
            int sixDice = 0;
            do
            {
                int terning = value.Next(1, 7);
                Console.WriteLine(terning);
                if (terning == 6)
                {
                    sixDice++;
                }
            } while (sixDice <= 5);
            Console.WriteLine("Tillykke, du har slået 6x seksere");
        }
    }
}
