using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character
{
    public string name;
    public int hp;

    //constructors
    public character(string name, int hp)
    {
        this.name = name;
        this.hp = hp;
    }
    //virtual attack
    public virtual int warriorattack()
    {
        return 0;
    }
    public virtual int wizardttack()
    {
        return 0;
    }

    
}

