using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class Deck: MonoBehaviour
{
    

    protected LinkedList<Card> Cards { get; set; }

    public Deck()
    {
        Cards = new LinkedList<Card>();
        //LinkedList<Card> CardDeck = new LinkedList<Card>();
        //GameManager cardlist = gameObject.GetComponent<GameManager>();
       // CardDeck = cardlist.Cards;

    }

    public void AddToTop(Card card)
    {
        Cards.AddFirst(card);
    } 

    public Card RemoveFromTop()
    {
        Card topCard = Cards.Last();
        Cards.RemoveLast();
        return topCard;
    }
    
}
