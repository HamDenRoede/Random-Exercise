using System;

namespace RandomExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //her er vores to metode-kald
            Terning();
            sixCount();
        }

        static void Terning()
        {
            
            Console.WriteLine("Throwing 10 dice");

            //her sætter vi en tilfældig variable via "Random" metoden
            Random value = new Random();

            //her starter vi et for loop, som looper 10 gange (se "i <=10)
            for (int i = 1; i <= 10; i++)
            {

                //her kastes vores terning. terningen er sekssidet. Det kan ses i "value.Next(1, 7);"
                int terning = value.Next(1, 7);
                Console.WriteLine(terning);
            }

            //loop færdig
            Console.WriteLine("Done with 10 dice \n");
        }

        static void sixCount()
        {

            Console.WriteLine("Throwing dice until 6x sixes");

            //her sætter vi igen variabler. Denne gang sætter vi også en variable som skal tælles hver gang terningen lander på "6"
            Random value = new Random();
            int sixDice = 0;
            do
            {

                //i dette loop kaster vi 1 terning ad gangen, i modsætning til 10 på én som i det tidligere loop
                int terning = value.Next(1, 7);
                Console.WriteLine(terning);

                //Her beder vi om at vores sixDice variable tæller op (incrementer), hver gang terningen lander på 6
                if (terning == 6)
                {
                    sixDice++;
                }
            } while (sixDice <= 5);
            //loopet stoppes ved 6x seksere
            Console.WriteLine("Tillykke, du har slået 6x seksere");
        }
    }
}
