using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardGame : MonoBehaviour
{
    //list of each card
    public List<string> cards = new List<string>
    {

    };

    //card suit list
    public List<string> suits = new List<string>
    {
        "diamonds",
        "hearts",
        "spades",
        "clubs"
    };

    //a dictionary of the deck of card suists and thier values
    public Dictionary<string, int> deck = new Dictionary<string, int>();


    //two card decks for each player 
    public List<string> deck1 = new List<string>();
    public List<string> deck2 = new List<string>();

    //declare cardvalue
    string cardValue;
    void Start()
    {
        int cardmax = 14;
        foreach (string suit in suits)
        {
            for (int i = 2; i <= cardmax; i++)
            {
                //gives values to cards above 10 
                cardValue = i.ToString() + " of " + suit;

                if (i == 14)
                {
                    cardValue = "Ace of " + suit;
                }

                else if (i == 13)
                {
                    cardValue = "King of " + suit;
                }

                else if (i == 12)
                {
                    cardValue = "Queen of " + suit;
                }

                else if (i == 11)
                {
                    cardValue = "Jack of " + suit;
                }

                //able to compare with other face cards 
                deck.Add(cardValue, i);
                cards.Add(cardValue);

            }
        }

        //calling the shuffing cards method
        Shuffle(cards);

        //creates two seperate decks for each player
        for (int i = 0; i <= 25; i++)
        {
            deck1.Add(cards[i]);
        }

        for (int i = 26; i <= 51; i++)
        {
            deck2.Add(cards[i]);
        }

        //keep track of how many times a player wins and ties
        int p2wins = 0;
        int p1wins = 0;
        int ties = 0;

        for (int i = 0; i <= 25; i++)
        {
            //compares the two values of each card and displays results
            //counter adds to running total of wins and ties
            if (deck[deck1[i]] > deck[deck2[i]])
            {
                Debug.LogFormat("player1:{0}    players2:{1}       player1 wins", deck1[i], deck2[i]);
                p1wins++;
            }
            else if (deck[deck1[i]] < deck[deck2[i]])
            {
                Debug.LogFormat("player1:{0}    players2:{1}       player2 wins", deck1[i], deck2[i]);
                p2wins++;
            }
            else
            {
                Debug.LogFormat("player1:{0}    players2:{1}       tie", deck1[i], deck2[i]);
                ties++;

            }
        }

        //display tally score
        Debug.LogFormat("player1's total wins: {0} player2's total wins:{1} ties: {2}", p1wins, p2wins, ties);
    }



    //shuffles the cards in the deck
    void Shuffle<T>(List<T> list)
    {
        System.Random random = new System.Random();
        int n = list.Count;
        while (n > 1)
        {
            int k = random.Next(n);
            n--;
            T temp = list[k];
            list[k] = list[n];
            list[n] = temp;
        }
    }

}
