/*********************************************************
* file name: Collections.cs
* programmer name: Matthew Schroeder
* date created: 9/1/125
* date of last revision: 9/27/19
* details of the revision: none
* short description:  determine if a 
* person's favorite color is primary or not.
**********************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collections : MonoBehaviour
{
    //list of people
    public List<string> names = new List<string>()
        {
            "Matt",
            "Dustin",
            "Lukas",
            "Jesus",
            "John",
            "Jimmy",
            "Jack",
            "Tyler",
            "Noah",
            "Drew"
        };


    //dictionary of names and favorite colors
    public Dictionary<string, string> namesandcolors = new Dictionary<string, string>()
    {
        {"Matt", "blue"},
        {"Dustin", "blue"},
        {"Lukas", "red"},
        {"Jesus", "red"},
        {"John", "yellow"},
        {"Jimmy", "pink"},
        {"Jack", "green"},
        {"Tyler", "purple"},
        {"Noah", "green"},
        {"Drew", "yellow"}
    };

    // Start is called before the first frame update
    void Start()
    {
        //generates a random number with a variable assigned to it
        int rnd = Random.Range(0, names.Count - 1);
        string rndname = names[rnd];


        //displays names and color
        if (namesandcolors.ContainsKey(rndname))
        {
            Debug.LogFormat("{0} is the name from the dictionary and his favorite color is {1}.", rndname, namesandcolors[rndname]);
        }


        //displays wether the favorite color is primary or not
        if (namesandcolors[rndname] == "red" || namesandcolors[rndname] == "yellow" || namesandcolors[rndname] == "blue")
        {
            Debug.LogFormat("{0}'s favorite color is primary.", rndname);
        }
        else
        {
            Debug.LogFormat("{0}'s favorite color is not primary.", rndname);
        }
    }
}

