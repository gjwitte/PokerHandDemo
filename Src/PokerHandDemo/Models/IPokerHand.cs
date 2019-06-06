using System.Collections.Generic;

namespace PokerHandDemo.Models
{
    public interface IPokerHand
    {
        List<Card> Cards { get; set; }
        int NumberOfCards { get; }
        string HandRanking { get; set; }
    }
}
