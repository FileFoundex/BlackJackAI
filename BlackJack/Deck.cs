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
            D[0 + i * 13] = new Card("Ace of " + suits[i], 1, 11);
            D[1+ i * 13] = new Card("Two of "+ suits[i],2);
            D[2+ i * 13] = new Card("Three of " + suits[i], 3);
            D[3+ i * 13] = new Card("Four of " + suits[i], 4);
            D[4+ i * 13] = new Card("Five of " + suits[i], 5);
            D[5+ i * 13] = new Card("Six of " + suits[i], 6);
            D[6+ i * 13] = new Card("Seven of " + suits[i], 7);
            D[7+ i * 13] = new Card("Eight of " + suits[i], 8);
            D[8+ i * 13] = new Card("Nine of " + suits[i], 9);
            D[9+ i * 13] = new Card("Ten of " + suits[i], 10);
            D[10+ i * 13] = new Card("Jack of " + suits[i], 10);
            D[11+ i * 13] = new Card("Queen of " + suits[i], 10);
            D[12+ i * 13] = new Card("King of " + suits[i], 10);
        }
    }
    
    public Card[] D
    {
        get => d;
        set => d = value ?? throw new ArgumentNullException(nameof(value));
    }
}