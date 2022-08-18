using System;

namespace RandomExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning();
        }

        static void Terning()
        {
            Random value = new Random();

           
            

            int sixDice = 0;
            string indicator = " ";
            do
            {
                int terning = value.Next(1, 7);
                Console.WriteLine(terning);
                if ("6".Contains(indicator))
                {
                    sixDice++;
                }
                for (int i = 1; i <= 10; i++)
                {

                    //int terning = value.Next(1, 7);
                    Console.WriteLine(terning);
                }
            } while (sixDice == 6);
        }
    }
}
