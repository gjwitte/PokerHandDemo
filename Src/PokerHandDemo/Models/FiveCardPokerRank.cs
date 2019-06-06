using System;
using System.Collections.Generic;
using System.Linq;

namespace PokerHandDemo.Models
{
    public class FiveCardPokerRank : IPokerRank
    {
        public string Rank { get; set; }
        public int Score { get; set; }
        public static List<string> Ranks => RankAndScore.Keys.ToList();
        

        public static Dictionary<string, int> RankAndScore => new Dictionary<string, int>
        {
            {"Two", 2},
            {"Three", 3},
            {"Four", 4},
            {"Five", 5},
            {"Six", 6},
            {"Seven", 7},
            {"Eight", 8},
            {"Nine", 9},
            {"Ten", 10},
            {"Jack", 11},
            {"Queen", 12},
            {"King", 13},
            {"Ace", 14}
        };

        public FiveCardPokerRank()
        {
            
        }

        public FiveCardPokerRank(string rank)
        {
            Rank = rank;
            Score = RankAndScore.FirstOrDefault(r => r.Key == Rank).Value;
        }
    }
}
