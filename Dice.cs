using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice
{
    private int _sides;
    private int _roll;

    //number of sides for the dice
    //0 side is equal to 6
    public int sides
    {
        get
        {
            if (_sides == 0)
            {
                _sides = 6;
            }
            return _sides;
        }

        set
        {
            _sides = value;
        }
    }

    public int roll
    {
        //random number between 1 and num of sides
        get
        {
            _roll = Random.Range(1, sides);
            return _roll;
        }
        set
        {
            _roll = value;
        }
    }
}

