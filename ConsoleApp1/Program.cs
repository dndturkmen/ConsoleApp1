using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] games = new int [100];
            string[] A = { "Rock", "Paper", "Scissors" };
            string oyuncu_A = A[2];
            string oyuncu_B;
            int gain_A = 0;
            int gain_B = 0;
            int scoreless = 0;

            for( int i=0; i<games.Length; i++)
            {
                Random rnd = new Random();
                oyuncu_B = A[rnd.Next(0, 3)];

                //makas kağıdı yener

                if (oyuncu_A == A[2] && oyuncu_B == A[0] || oyuncu_A == A[0] && oyuncu_B == A[1] || oyuncu_A == A[1] && oyuncu_B == A[2])
                {
                    gain_B++;
                }
                else if (oyuncu_A == A[0] && oyuncu_B == A[2] || oyuncu_A == A[1] && oyuncu_B == A[0] || oyuncu_A == A[2] && oyuncu_B == A[1])
                {
                    gain_A++;
                }
                else
                {
                    scoreless++;
                }


            }

            Console.WriteLine("Player A wins "+gain_A+ " of 100 games");
            Console.WriteLine("Player B wins " + gain_B+ " of 100 games");
            Console.WriteLine("Tie:" +scoreless+ " of 100 games");
        }
    }
}
