using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warrior : character
{
    public string warname;

    //constuctor calling base 
    public warrior(string name, int hp) : base(name, hp)
    {
        this.warname = name;
        Debug.LogFormat("{0} is ready for battle. HP: {1}", this.warname, hp);
    }

    //override attack method: how much damage of attack
    public override int warriorattack()
    {
        int att = Random.Range(3, 5);
        Debug.LogFormat("{0} attacked for {1} damage", this.warname, att);
        return att;
    }

}

