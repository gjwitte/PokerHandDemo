using System.Collections.Generic;

namespace PokerHandDemo.Models
{
    public interface IPokerRank
    {
        string Rank { get; set; }
        int Score { get; set; }
    }
}
