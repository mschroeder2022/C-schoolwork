using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class battle : MonoBehaviour
{
    public int wizardhp = 33;
    public int warriorhp = 20;
    void Start()
    {
        //create character objects
        wizard John = new wizard("John", wizardhp);
        warrior Matt = new warrior("Matt", warriorhp);

        //battle runs until one player is not above 0hp
        while (wizardhp > 0 && warriorhp > 0)
        {
            wizardhp -= Matt.warriorattack();
            warriorhp -= John.wizardttack();
            wizardhp += John.heal;
            Debug.LogFormat("{0} HP: {1}. {2} HP: {3}", John, wizardhp, Matt, warriorhp);
        }


        //victory message
        if (wizardhp <= 0)
        {
            Debug.LogFormat("{0} is victorious and {1} has died.", Matt, John);
        }
        else if (warriorhp <= 0)
        {
            Debug.LogFormat("{0} is victorious and {1} has died.", John, Matt);
        }
    }

}

