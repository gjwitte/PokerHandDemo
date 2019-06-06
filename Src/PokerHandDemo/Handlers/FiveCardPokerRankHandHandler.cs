using System.Collections.Generic;
using PokerHandDemo.Models;
using PokerHandDemo.Models.HandRankings;

namespace PokerHandDemo.Handlers
{
    public class FiveCardPokerRankHandHandler : IRankHandHandler
    {
        public List<T> Calculate<T>(List<T> hands) where T : IPokerHand
        {
            foreach (var hand in hands)
            {
                hand.HandRanking = GetScore(hand);
            }

            return hands;
        }

        private string GetScore(IPokerHand hand)
        {
            var royalFlush = new RoyalFlush(hand);
            if (royalFlush.IsHighRank)
                return royalFlush.Title;

            var straightFlush = new StraightFlush(hand);
            if (straightFlush.IsHighRank)
                return straightFlush.Title;

            var fourOfAKind = new FourOfAKind(hand);
            if (fourOfAKind.IsHighRank)
                return fourOfAKind.Title;

            var fullHouse = new FullHouse(hand);
            if (fullHouse.IsHighRank)
                return fullHouse.Title;

            var flush = new Flush(hand);
            if (flush.IsHighRank)
                return flush.Title;
            
            var straight = new Straight(hand);
            if (straight.IsHighRank)
                return straight.Title;

            var threeOfAKind = new ThreeOfAKind(hand);
            if (threeOfAKind.IsHighRank)
                return threeOfAKind.Title;
            
            var twoPair = new TwoPair(hand);
            if (twoPair.IsHighRank)
                return twoPair.Title;
            
            var onePair = new OnePair(hand);
            if (onePair.IsHighRank)
                return onePair.Title;

            return "High Card";
        }
    }
}
