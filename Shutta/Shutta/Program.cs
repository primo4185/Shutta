using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shutta
{
    class Program
    {
        static void Main(string[] args)
        {
            Diller diller = new Diller();

            Board board = new Board();

            List<Player> players = new List<Player>();
            players.Add(new Player(0));
            players.Add(new Player(1));

            Scorer scorer = new Scorer();

            while (CanGoRound(players))
            {
                diller.Shuffle();
                for (int i = 0; i < players.Count; i++)
                {
                    players[i].Money -= 100;
                    board.Money += 100;

                }

                for (int i = 0; i < players.Count; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        Card card = diller.GetCard();
                        players[i].TakeCard(card);
                    }
                }

                Player winner = scorer.GetWinner(players[0], players[1]);
                if (winner == null)
                    continue;

                winner.Money += board.Money;
                board.Money = 0;

                PrintRoundResult(players, winner);

            }




        }

        private static void PrintRoundResult(List<Player> players, Player winner)
        {
            for (int i = 0; i < players.Count; i++)
            {
                Console.WriteLine($"P{players[i].No}: {players[i].Money}");

                for (int j = 0; j < 2; j++)
                {
                    Console.Write(players[i].Cards[j].ToText() + "/");
                }
                Console.WriteLine($"승자는 {winner.No}.");
            }
        }

        static bool CanGoRound(List<Player> players)
        {
            if (players[0].Money > 0 && players[1].Money > 0)
                return true;
            return false;
        }

    }

}
