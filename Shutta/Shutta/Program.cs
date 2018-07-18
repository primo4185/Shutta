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
            players.Add(new Player());
            players.Add(new Player());

            while (CanGoRound(players))
            {

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
