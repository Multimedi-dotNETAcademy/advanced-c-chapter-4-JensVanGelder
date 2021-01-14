using System;
using System.Collections.Generic;

namespace Speelkaarten
{
    public enum Suite
    {
        Spades = 1,
        Hearts = 2,
        Clubs = 3,
        Diamonds = 4
    }

    internal class Speelkaart
    {
        public int Card { get; set; }
        public Suite Suite { get; set; }

        public void CreateDeck(List<Speelkaart> Deck)
        {
            foreach (Suite suit in (Suite[])Enum.GetValues(typeof(Suite)))
            {
                for (int i = 1; i < 14; i++)
                {
                    Speelkaart kaart = new Speelkaart
                    {
                        Card = i,
                        Suite = suit
                    };
                    Deck.Add(kaart);
                }
            }
        }

        public string GetInfo()
        {
            if (Card == 11)
            {
                return $"Jack of {Suite}";
            }
            else if (Card == 12)
            {
                return $"Queen of {Suite}";
            }
            else if (Card == 13)
            {
                return $"King of {Suite}";
            }
            else if (Card == 1)
            {
                return $"Ace of {Suite}";
            }
            else
            {
                return $"{Card} of {Suite}";
            }
        }
    }
}