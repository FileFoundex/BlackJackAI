namespace BlackJack;

public class Deck
{
    private Card[] d = new Card[52];
    
    public Deck()
    {
        populateDeck();
    }

    private void populateDeck()
    {
        string[] suits = { "Hearts", "Clubs", "Spades", "Diamonds" };
        for (int i = 0; i < 4; i++)
        {
            d[0 + i * 13] = new Card("Ace of " + suits[i], 1, 11);
            d[1+ i * 13] = new Card("Two of "+ suits[i],2);
            d[2+ i * 13] = new Card("Three of " + suits[i], 3);
            d[3+ i * 13] = new Card("Four of " + suits[i], 4);
            d[4+ i * 13] = new Card("Five of " + suits[i], 5);
            d[5+ i * 13] = new Card("Six of " + suits[i], 6);
            d[6+ i * 13] = new Card("Seven of " + suits[i], 7);
            d[7+ i * 13] = new Card("Eight of " + suits[i], 8);
            d[8+ i * 13] = new Card("Nine of " + suits[i], 9);
            d[9+ i * 13] = new Card("Ten of " + suits[i], 10);
            d[10+ i * 13] = new Card("Jack of " + suits[i], 10);
            d[11+ i * 13] = new Card("Queen of " + suits[i], 10);
            d[12+ i * 13] = new Card("King of " + suits[i], 10);
        }
    }
    
    public Card[] deck
    {
        get => d;
        set => d = value ?? throw new ArgumentNullException(nameof(value));
    }
}