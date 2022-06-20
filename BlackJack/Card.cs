namespace BlackJack;

public class Card
{
    private int value;
    private string name;
    private int secondaryValue;

    public Card(string name, int value)
    { 
        this.name = name;
        this.value = value;
        this.secondaryValue = 0;
    }
    
  
    public string Name
    {
        get { return name; }
    }

    public int Value
    {
        get { return value; }
    }
 
}

public class Ace : Card
{
    private int secondaryValue;
    
    public Ace(string name, int value, int secondaryValue) : base(name , value)
    {
        this.secondaryValue = secondaryValue;
    }
    
    public int SecondaryValue
    {
        get { return secondaryValue; }
    }
}


