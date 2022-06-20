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
    }
    
    public Card(string name, int value, int secondaryValue)
    {
        this.name = name;
        this.value = value;
        this.secondaryValue = secondaryValue;
    }
  
    public string Name
    {
        get { return name; }
    }

    public int Value
    {
        get { return value; }
    }
    
    public int SecondaryValue
    {
        get { return secondaryValue; }
    }
}



