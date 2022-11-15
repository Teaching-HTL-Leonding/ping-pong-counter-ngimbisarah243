using System;

namespace pingpong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Game mode?  ");
            string gameMode = Console.ReadLine();

            int numberoffGames = 0;
            int servingPlayer = 0;

            switch (gameMode)
            {
                case "short": numberoffGames = 1; break;
                case "regular": numberoffGames = 4; break;
                case "double": numberoffGames = 3; break;
                case "custom":
                    do
                    {
                        Console.Write("How many games? ");
                        numberoffGames = Convert.ToInt32(Console.ReadLine()!);
                    } while (numberoffGames <= 0 || numberoffGames > 9 || numberoffGames % 2 == 0); break;
            }

            int points1 = 0, points2 = 0, games1 = 0, games2 = 0;

            do
            {
                servingPlayer = new Random().Next(1, 3);

                points1 = points2 = 0;
                do
                {
                    Console.WriteLine($"Player {servingPlayer} has the service");
                    Console.WriteLine("Who has won?  ");
                    char winner = Convert.ToChar(Console.ReadLine()!);
                    if (winner == 1) { points1++; }
                    else if(winner == 2){ points2++; }
                    else if (winner == 'q') { Console.WriteLine("UNFORTUNATELY THE GAME HAS TO GET ENDED"); return; }
                    
                } while (points1 < 11 && points1 < 11);

                if (points1 == 11) { Console.WriteLine("Player 1 has won a game"); games1++; }
                else { Console.WriteLine("Player 2 has won a game"); games2++; }

                Console.WriteLine($"Games: {games1}:{games2}");

            } while (games1 < numberoffGames && games2 < numberoffGames);

            if (games1 == numberoffGames)
            {
                Console.WriteLine("Congrats, player 1, you won the match");
            }
            else
            {
                Console.WriteLine("Congrats, player 2, you won the match");
            }
        }
    }

}
