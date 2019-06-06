using PokerHandDemo.Models;
using System.Collections.Generic;

namespace PokerHandDemo.Handlers
{
    public interface IRankHandHandler
    {
        List<T> Calculate<T>(List<T> hands) where T : IPokerHand;
    }
}
