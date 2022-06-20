// See https://aka.ms/new-console-template for more information
using BlackJack;

Console.WriteLine("Hello, World!");
Console.ReadLine();

Deck deck = new Deck();

for (int i = 0; i < deck.deck.Length; i++)
{
    if (deck.deck[i].Value != 1)
    {
        Console.WriteLine(deck.deck[i].Name + " " + deck.deck[i].Value);
    }
    else
    {
        Console.WriteLine(deck.deck[i].Name + " " + deck.deck[i].Value + " " + deck.deck[i].SecondaryValue);
    }
}



