using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shutta
{
    public class Scorer
    {
        /// <summary>
        /// 승자를 구한다.
        /// </summary>
        /// <param name="p0">플레이어0</param>
        /// <param name="p1">플레이어1</param>
        /// <returns>두 플레이어 중 승자, 만약 무승부면 null을 반환</returns>
        public Player GetWinner(Player p0, Player p1)
        {
            int score0 = CalculateScore(p0);
            int score1 = CalculateScore(p1);

            if (score0 > score1)
                return p0;
            else if (score1 > score0)
                return p1;
            else
                return null;

            
        }
        private int CalculateScore(Player p)
        {
            int score = p.Cards[0].Number + p.Cards[1].Number;
                score = score % 10;

            if (p.Cards[0].Number == p.Cards[1].Number)
                score += 100;

            if (p.Cards[0].isKwang && p.Cards[1].isKwang)
                score += 10000;

            return score;
        }

    }
}