using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Mood enum
public enum Mood
{
    Sad,
    Neutral,
    Happy
}

public class Gambler : MonoBehaviour
{
    //dice object for the roll and what the gambler guesses.
    Dice die = new Dice();
    Dice guess = new Dice();
    Mood tim;

    void Start()
    {
        //mood starts at neutral at beginning
        tim = Mood.Neutral;
    }


    void Update()
    {
        //checks to see if the guess was higher, same, or lower
        //outputting a mood based on the result
        if (Input.GetKeyDown(KeyCode.Space))
        {

            int rolls = die.roll;
            int guesser = guess.roll;

            if (guesser > rolls)
            {
                tim = Mood.Happy;
                Debug.LogFormat("roll: {0} guess: {1}. The gamblers mood is {2}", rolls, guesser, tim);
            }
            else if (guesser == rolls)
            {
                tim = Mood.Neutral;
                Debug.LogFormat("roll: {0} guess: {1}. The gamblers mood is {2}", rolls, guesser, tim);
            }
            else if (guesser < rolls)
            {
                tim = Mood.Sad;
                Debug.LogFormat("roll: {0} guess: {1}.The gamblers mood is {2}", rolls, guesser, tim);
            }
        }
    }
}

