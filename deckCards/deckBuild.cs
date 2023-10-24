using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deckCards
{    public class deckBuild
     {
        public List<Deck> Deck = new List<Deck>();
        private string[] Suits = { "Spades", "Hearts", "Diamonds", "Clubs" };
        private string[] Ranks = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
        public void newDeck()
        {
            Deck.Clear();
            foreach (string suit in Suits)
            {
                foreach (string rank in Ranks)
                {
                    Deck card = new Deck(suit, rank);
                    Deck.Add(card);
                }
            }
        }
        public void Shuffle()
        {
            Random random = new Random();
            int deckAmount = Deck.Count;
            while (deckAmount > 1)
            {
                deckAmount--;
                int k = random.Next(deckAmount + 1);
                Deck temp = Deck[k];
                Deck[k] = Deck[deckAmount];
                Deck[deckAmount] = temp;
            }

        }
        public int remainingCards()
        {
            return Deck.Count;
        }
        public string[] drawCard()
        {
            string[] drawnCard = new string[2];
            if (Deck.Count > 0)
            {
                Deck card = Deck[0];
                Deck.RemoveAt(0);
                drawnCard[0] = card.Rank;
                drawnCard[1] = card.Suit;
                return drawnCard;
            }
            else
            {
                return null;
            }
        }
     }
    public class Deck
    {
        public string Suit { get; set; }
        public string Rank { get; set; }

        public Deck(string suit, string rank)
        {
            Suit = suit;
            Rank = rank;
        }
    }
}
