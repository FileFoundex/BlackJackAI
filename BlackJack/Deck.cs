namespace BlackJack;
using System.Collections.Generic;


public class Deck
{
    private List<Card> d = new List<Card>();
    
    public Deck()
    {
        
    }

    public void populateDeck()
    {
        string[] suits = { "Hearts", "Clubs", "Spades", "Diamonds" };
        for (int i = 0; i < 4; i++)
        {
            d.Add(new Ace("Ace of " + suits[i], 11, 1));
            d.Add(new Card("Two of "+ suits[i],2));
            d.Add( new Card("Three of " + suits[i], 3));
            d.Add(new Card("Four of " + suits[i], 4));
            d.Add(new Card("Five of " + suits[i], 5));
            d.Add(new Card("Six of " + suits[i], 6));
            d.Add(new Card("Seven of " + suits[i], 7));
            d.Add(new Card("Eight of " + suits[i], 8));
            d.Add(new Card("Nine of " + suits[i], 9));
            d.Add(new Card("Ten of " + suits[i], 10));
            d.Add(new Card("Jack of " + suits[i], 10));
            d.Add(new Card("Queen of " + suits[i], 10));
            d.Add(new Card("King of " + suits[i], 10));
        }
    }
    
    public List<Card> deck
    {
        get => d;
        set => d = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Total()
    
    {
        int tot = 0;
        int numOfAces = 0;
        foreach (var item in d)
        {
            if (item.GetType() != typeof(Ace))
            {
                tot += item.Value;
            }
        }

        foreach (var item in d)
        {
            if (item.GetType() == typeof(Ace))
            {
                numOfAces++;
            }
        }
        
        int numToHave11 = (int)Math.Floor(((21 - (double)tot) / 11));

        tot += numToHave11 * 11 + (numOfAces - numToHave11);

        return tot;

    }
}