/*********************************************************
* file name: Iterators.cs
* programmer name: Matthew Schroeder
* date created: 10/2/19
* date of last revision: 10/2/19
* details of the revision: none
* short description:  determine if a 
* person's favorite color is primary or not. dsiplay two multiplication
* tables with a while and for loop
**********************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iterators : MonoBehaviour
{
    //user enters num
    public int number;

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
        //for loop multiplication table
        for (int j = 1; j <= 10; j++)
        {
            //displays table
            Debug.LogFormat("{0} X {1} = {2} \n", number, j, number * j);
        }

        int z = 1; //initialization

        //while loop multiplication table
        while (z <= 10)
        {
            //displays table
            Debug.LogFormat("{0} * {1} = {2} \n", number, z, (number * z));
            z++; // increment by 1
        }

      
        for (int i = 0; i < 10; i++)
        {
            //generates a random number with a variable assigned to it
            int rnd = Random.Range(0, names.Count - 1);
            string rndname = names[rnd];

            //displays wether the favorite color is primary or not
            if (namesandcolors[rndname] == "red" || namesandcolors[rndname] == "yellow" || namesandcolors[rndname] == "blue")
            {
                Debug.LogFormat("{0}'s favorite color is {1} and it is primary.", rndname, namesandcolors[rndname]);
            }
            else
            {
                Debug.LogFormat("{0}'s favorite color is {1} and it is not primary.", rndname, namesandcolors[rndname]);
            }
        }
    }
}
