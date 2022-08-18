using System;

namespace RandomExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //her er vores to metode-kald
            //Terning();
            //sixCount();
            switchCount();
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

        static void switchCount()
        {
            
            for (int i = 1; i <= 10; i++)
            {

                Random value = new Random();
                int rand = value.Next(1, 7);

                int antalEttere = 0;
                int antalToere = 0;
                int antalTreere = 0;
                int antalFirere = 0;
                int antalFemmere = 0;
                int antalSeksere = 0;

                //her kastes vores terning. terningen er sekssidet. Det kan ses i "value.Next(1, 7);"
                //int terning = value.Next(1, 7);
                //int startValue = 1;
                //int input = int.Parse(Console.ReadLine());
                //Console.WriteLine(value);

                switch (rand)
                {
                    case 1:
                            antalEttere++;
                        Console.WriteLine("Du slog en etter");
                            break;
                    case 2:
                            antalToere++;
                        Console.WriteLine("Du slog en toer");
                        break;
                    case 3:
                            antalTreere++;
                        Console.WriteLine("Du slog en treer");
                        break;
                    case 4:
                            antalFirere++;
                        Console.WriteLine("Du slog en firer");
                        break;
                    case 5:
                            antalFemmere++;
                        Console.WriteLine("Du slog en femmer");
                        break;
                    case 6:
                            antalSeksere++;
                        Console.WriteLine("Du slog en sekser");
                        break;
                        
                }
            }
        }
    }
}
