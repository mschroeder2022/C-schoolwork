using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//not inherit from MonoBehavior.
public class Movie
{
    //declaring variables
    public string title;
    public int Year;
    public string Genre;

    //Constructor
    public Movie(string Genre, int Year, string title)
    {
        this.title = title;
        this.Year = Year;
        this.Genre = Genre;
    }

    //Methods to call in MovieGoers.cs

    //Display movie title and year
    public void DisplayInfo()
    {
        Debug.LogFormat("Then movie's name is {0} from {1}", title, Year);
    }

    
    //Checking for favorite and least favorite genre and 
    //see if the movie was from the favorite decade.
    public void CalculateCompatibility(string favGenre, string leastFavGenre, int favDecade)
    {
        if (favGenre==Genre)
        {
            Debug.LogFormat("The movie's name is a {0}.", Genre);
        }
        else
        {
            Debug.LogFormat("The movie's name is not a {0}",Genre);
        }
        if (leastFavGenre==Genre)
        { 
            Debug.LogFormat("The movie's name is a {0}. I do not like theses type of movies.", title);
        }
        else
        {
            Debug.LogFormat("The movie's name is {0}.", title, Year);
        }
        if (favDecade>=1990 && favDecade<2000)
        {
            Debug.LogFormat("The movie's name is {0} from {1}. It is from my favorite decade.", title, Year);
        }
        else
        {
            Debug.LogFormat("The movie's name is {0} from {1}. I do not like movies from this decade.", title, Year);
        }
    }
}