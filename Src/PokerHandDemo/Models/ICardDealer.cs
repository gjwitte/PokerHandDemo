using System.Collections.Generic;

namespace PokerHandDemo.Models
{
    public interface ICardDealer
    {
        List<Card> BuildDeck();
        List<T> Deal<T>(List<Card> deck, int numberOfHands) where T : IPokerHand, new();
    }
}
