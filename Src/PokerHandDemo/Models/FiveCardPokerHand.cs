using System.Collections.Generic;

namespace PokerHandDemo.Models
{
    public class FiveCardPokerHand : IPokerHand
    {
        public List<Card> Cards { get; set; }
        public int NumberOfCards => 5;
        public string HandRanking { get; set; }
    }
}
