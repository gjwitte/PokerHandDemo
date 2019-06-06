namespace PokerHandDemo.Models
{
    public interface IPokerSuit
    {
        Suits Type { get; set; }
    }

    public enum Suits
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
}
