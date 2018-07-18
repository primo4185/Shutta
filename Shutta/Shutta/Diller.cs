using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shutta
{
    public class Diller
    {
        //public Card[] Cards;
        private List<Card> _cards = new List<Card>();
        List<int> _kwangNumers = new List<int> { 1, 3, 8 };
        public void Shuffle()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Card card = new Card();
                    card.Number = i + 1;
                    card.isKwang = false;
                    if(j == 0)
                    {          
                        if (_kwangNumers.Contains(card.Number))
                            card.isKwang = true;


                        //Cards[i + j * 2] = card;
                        _cards.Add(card);
                    }

                    _cards.OrderBy(x => Guid.NewGuid()).ToList(); //랜덤 정렬
                    _index = 0;
                }
            }

        }

        private int _index = 0;
            public Card GetCard()
        {
            return _cards[_index++];
            //Card card = Cards[_index];
            //_index +;
            //return card;
        }
    }
}