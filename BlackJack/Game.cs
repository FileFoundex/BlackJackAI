namespace BlackJack;

public class Game
{
    private Deck deck = new Deck();
    private Player p = new Player();
    private bool finished = false;
    private Dealer dealer = new Dealer();
    
    public enum Choice
    {
        hit,
        stand
    }
    
    public Game(Player p)
    {
        deck.populateDeck();
    }

    public void StartGame()
    {
        dealer.Initialise(deck);
        p.Initialise(deck);
        while (!finished)
        {
            Console.WriteLine("Dealers hand: " + dealer.Hand.deck[0].Name + " Hidden");
            Console.Write("PLayers hand: ");
            foreach (var VARIABLE in p.Hand.deck)
            {
                Console.Write(VARIABLE.Name + "  ");
            }
            Console.Write( "| Total " + p.Hand.Total());
            Console.WriteLine();
            Console.WriteLine("0 to Hit , 1 to stand");
            switch (Console.ReadLine())
            {
                case "0": finished = p.Move(Choice.hit, deck);
                    break;
                case "1": finished = p.Move(Choice.stand, deck);
                    break; 
            }
        }

        if (p.Hand.Total() > 21)
        {
            Console.WriteLine("BUST");
            Console.WriteLine("YOU LOSE");
            Console.Write("Dealers Hand: "  );
            foreach (var VARIABLE in dealer.Hand.deck)
            {
                Console.Write(VARIABLE.Name + " ");
            }
            Console.Write( "| Total " + dealer.Hand.Total());
            Console.WriteLine();
        }
        else if (p.Hand.Total() == 21)
        {
            Console.WriteLine("BlackJack");
            Console.WriteLine("YOU WIN");
            Console.Write("Dealers Hand: "  );
            foreach (var VARIABLE in dealer.Hand.deck)
            {
                Console.Write(VARIABLE.Name + " ");
            }
            Console.Write( "| Total " + dealer.Hand.Total());
            Console.WriteLine();
        }
        else
        {
            Console.Write("Dealers Hand: "  );
            foreach (var VARIABLE in dealer.Hand.deck)
            {
                Console.Write(VARIABLE.Name + " ");
            }

            finished = false;
            while (dealer.Hand.Total() < 16 && dealer.Hand.Total() < p.Hand.Total() && !finished)
            {
                finished = dealer.Move(Choice.hit, deck);
                Console.Write(dealer.Hand.deck[dealer.Hand.deck.Count - 1].Name + " ");
                Thread.Sleep(1000);
            }
            Console.Write( "| Total " + dealer.Hand.Total());
            Console.WriteLine();
            if (dealer.Hand.Total() > 21)
            {
               Console.WriteLine("YOU WIN");
            }
            else if (dealer.Hand.Total() == 21 || dealer.Hand.Total() > p.Hand.Total())
            {
                Console.WriteLine("YOU LOSE");
            }
            else
            {
                Console.WriteLine("YOU WIN");  
            }

        }
        
        Console.Write("PLayers hand: ");
        foreach (var VARIABLE in p.Hand.deck)
        {
            Console.Write(VARIABLE.Name + "  ");
        }
        Console.Write( "| Total " + p.Hand.Total());
        Console.WriteLine();
        Console.WriteLine("Press Enter To replay");
        Console.ReadLine();
        Console.Clear();
        Game g = new Game(new Player());
        g.StartGame();    
    }
}