namespace BlackJack;

public class Player
{

    protected Deck hand = new Deck();
    protected Random rand = new Random();


    public Deck Hand
    {
        get => hand;
        set => hand = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Player()
    {
        
    }

    public virtual bool Move(Game.Choice x, Deck deck)
    {
        bool finished = false;
        if (x == Game.Choice.hit)
        {
            int r = rand.Next(0, deck.deck.Count-1);
            hand.deck.Add(deck.deck[r]);
            deck.deck.RemoveAt(r);
        }
        if (x == Game.Choice.stand || hand.Total() >= 21)
        {
            finished = true;
        }
        return finished;
    }
    
    public virtual void Initialise(Deck deck)
    {
        int r = rand.Next(0, deck.deck.Count - 1);
        hand.deck.Add(deck.deck[r]);
        deck.deck.RemoveAt(r);
        
        r = rand.Next(0, deck.deck.Count - 1);
        hand.deck.Add(deck.deck[r]);
        deck.deck.RemoveAt(r);
        return;
    }
    
    
}

public class Dealer : Player
{
    public Dealer()
    {
       
    }
    public override void Initialise(Deck deck)
    {
        int r = rand.Next(0, deck.deck.Count - 1);
        hand.deck.Add(deck.deck[r]);
        deck.deck.RemoveAt(r);
        
        r = rand.Next(0, deck.deck.Count - 1);
        hand.deck.Add(deck.deck[r]);
        deck.deck.RemoveAt(r);
        return;
    }

    public override bool Move(Game.Choice x, Deck deck)
    {
        return base.Move(x, deck);
    }
}