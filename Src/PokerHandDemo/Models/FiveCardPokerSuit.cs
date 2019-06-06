using System.Collections.Generic;

namespace PokerHandDemo.Models
{

    public class FiveCardPokerSuit : IPokerSuit
    {
        public Suits Type { get; set; }
        public static List<Suits> Suits => GetSuits();

        public FiveCardPokerSuit()
        {
            
        }

        public FiveCardPokerSuit(Suits suit)
        {
            Type = suit;
        }

        private static List<Suits> GetSuits()
        {
            var suits = new List<Suits>
            {
                Models.Suits.Clubs,
                Models.Suits.Diamonds,
                Models.Suits.Hearts,
                Models.Suits.Spades
                
            };
            return suits;
        }
    }
}
