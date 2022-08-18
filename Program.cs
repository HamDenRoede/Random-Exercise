using System;

namespace RandomExercises
{
    class Program
    {
        static Random value = new Random();

        static void Main(string[] args)
        {
            Terning();
        }

        static void Terning()
        {
            

            for (int i = 1; i <= 10; i++)
            {
                Random value = new Random();
                int terning = value.Next(1, 7);
                Console.WriteLine(terning);

            }
        }
    }
}
