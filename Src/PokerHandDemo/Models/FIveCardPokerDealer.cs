using System;
using System.Collections.Generic;

namespace PokerHandDemo.Models
{
    public class FiveCardPokerDealer : ICardDealer
    {
        private static readonly Random RandomGenerator = new Random();
        public List<Card> BuildDeck()
        {
            var deck = new List<Card>();
            var suits = FiveCardPokerSuit.Suits;
            var ranks = FiveCardPokerRank.Ranks;
            
            foreach (var suit in suits)
            {
                foreach (var rank in ranks)
                {
                    deck.Add(new Card
                    {
                        Suit = new FiveCardPokerSuit(suit),
                        Rank = new FiveCardPokerRank(rank)
                    });
                }
            }
            return deck;
        }

        public List<T> Deal<T>(List<Card> deck, int numberOfHands) where T : IPokerHand, new()
        {
            var hands = new List<T>();

            for (int i = 0; i < numberOfHands; i++)
            {
                var hand = new T();
                var cardsInHand = new List<Card>();

                for (int c = 0; c < hand.NumberOfCards; c++)
                {
                    var randomPosition = RandomGenerator.Next(deck.Count);
                    var selectedCard = deck[randomPosition];
                    cardsInHand.Add(selectedCard);
                    deck.Remove(selectedCard);
                }

                hand.Cards = cardsInHand;
                hands.Add(hand);
            }

            return hands;
        }
    }
}
