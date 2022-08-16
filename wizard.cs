using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wizard : character
{
    public int heal;
    public string wizardname;

    //constuctor calling base 
    public wizard(string name, int hp) : base(name, hp)
    {
        this.wizardname = name;
        Debug.LogFormat("{0} is ready for battle. HP: {1}", this.wizardname, hp);
    }

    //override attack method: how much damage of attack and heal spell
    public override int wizardttack()
    {
        int spell = Random.Range(1, 3);
        heal = Random.Range(0, 3);
        hp += heal;
        Debug.LogFormat("{0} used a spell for {1} damage and healed for {2} HP", this.wizardname, spell, heal);
        return spell;

    }

}

