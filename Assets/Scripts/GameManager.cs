using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject CardPrefab;
    private PokerDeck _deck;
    public static LinkedList<Card> Cards;

    public Card Card;
    public Card Card1;
    public Card Card2;
    public Card Card3;
    public Card Card4;
    public Card Card5;
    public Card Card6;
    public Card Card7;
    public Card Card8;
    public Card Card9;
    public Card Card10;
    public Card Card11;
    public Card Card12;
    public Card Card13;
    public Card Card14;
    public Card Card15;
    public Card Card16;
    public Card Card17;
    public Card Card18;
    public Card Card19;
    public Card Card20;
    public Card Card21;
    public Card Card22;
    public Card Card23;
    public Card Card24;
    public Card Card25;
    public Card Card26;
    public Card Card27;
    public Card Card28;
    public Card Card29;
    public Card Card30;
    public Card Card31;
    public Card Card32;
    public Card Card33;
    public Card Card34;
    public Card Card35;
    public Card Card36;
    public Card Card37;
    public Card Card38;
    public Card Card39;
    public Card Card40;
    public Card Card41;
    public Card Card42;
    public Card Card43;
    public Card Card44;
    public Card Card45;
    public Card Card46;
    public Card Card47;
    public Card Card48;
    public Card Card49;
    public Card Card50;
    public Card Card51;

    // Start is called before the first frame update
    void Start()
    {
        Cards = new LinkedList<Card>();
        AddDeck();

        _deck = new PokerDeck();
        DrawTopCard();
    }

    //Draws top card from deck and displays it on the screen
    void DrawTopCard()
    {
        if (CardPrefab != null)
        {
            var card = GameObject.Instantiate<GameObject>(CardPrefab, Vector3.zero, Quaternion.identity);
            var controller = card.GetComponent<CardController>();

            //attach card C# object to card Unity object
            controller.Card = _deck.RemoveFromTop();

            if (controller != null)
            {
                controller.FaceMaterial = PokerCardFactory.GetInstance().Materials[controller.Card.Name];
                controller.UpdateFaceMaterial();
            }
        }
    }

    public void Shuffle()
    {
        LinkedList<Card> tempCards = new LinkedList<Card>();
        List<Card> cardsVec = new List<Card>();

        //int ranNum = random.Next(0, cards.Count);

        //Loop through the cards linked list 0(1) op. 
        //After copying through a vector I then find random ranges in the vector and insert into the deck
        foreach (var item in Cards)
        {
            cardsVec.Add(item);
        }

        foreach (var item in Cards)
        {
            tempCards.AddLast(cardsVec[Random.Range(0, cardsVec.Count)]);
            cardsVec.RemoveAt(cardsVec.Count - 1);
            Debug.Log("the deck as been shuffled");
        }
        Cards.Clear();
        Cards = tempCards;
    }

    public void AddCardsToDeck()
    {
        Cards.AddFirst(Card1);
        Cards.AddFirst(Card2);
        Cards.AddFirst(Card3);
        Cards.AddFirst(Card4);
        Cards.AddFirst(Card5);
        Cards.AddFirst(Card6);
        Cards.AddFirst(Card7);
        Cards.AddFirst(Card8);
        Cards.AddFirst(Card9);
        Cards.AddFirst(Card10);
        Cards.AddFirst(Card11);
        Cards.AddFirst(Card12);
        Cards.AddFirst(Card13);
        Cards.AddFirst(Card14);
        Cards.AddFirst(Card15);
        Cards.AddFirst(Card16);
        Cards.AddFirst(Card17);
        Cards.AddFirst(Card18);
        Cards.AddFirst(Card19);
        Cards.AddFirst(Card20);
        Cards.AddFirst(Card21);
        Cards.AddFirst(Card22);
        Cards.AddFirst(Card23);
        Cards.AddFirst(Card24);
        Cards.AddFirst(Card25);
        Cards.AddFirst(Card26);
        Cards.AddFirst(Card27);
        Cards.AddFirst(Card28);
        Cards.AddFirst(Card29);
        Cards.AddFirst(Card30);
        Cards.AddFirst(Card31);
        Cards.AddFirst(Card32);
        Cards.AddFirst(Card33);
        Cards.AddFirst(Card34);
        Cards.AddFirst(Card35);
        Cards.AddFirst(Card36);
        Cards.AddFirst(Card37);
        Cards.AddFirst(Card38);
        Cards.AddFirst(Card39);
        Cards.AddFirst(Card40);
        Cards.AddFirst(Card41);
        Cards.AddFirst(Card42);
        Cards.AddFirst(Card43);
        Cards.AddFirst(Card44);
        Cards.AddFirst(Card45);
        Cards.AddFirst(Card46);
        Cards.AddFirst(Card47);
        Cards.AddFirst(Card48);
        Cards.AddFirst(Card49);
        Cards.AddFirst(Card50);
        Cards.AddFirst(Card51);
}
    public void AddDeck()
    {
        AddCardsToDeck();
        Debug.Log(Cards.Count);
        Shuffle();

    }

    public void DrawFromBottom()
    {
        Cards.RemoveFirst();
        Debug.Log(Cards.Count);
    }

    public void DrawFromTop()
    {
        Cards.RemoveLast();
        Debug.Log(Cards.Count);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
