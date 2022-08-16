using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovieGoer : MonoBehaviour
{
    //declaring variables
    public string favoriteGenre;
    public string leastFavoriteGenre;
    public int favoriteDecade;

    // Start is called before the first frame update
    void Start()
    {
        //set the film type, year produced, title
        Movie film = new Movie("Drama", 1994, "Forest Gump");

        //display film's
        Debug.LogFormat("The film's name is {0}", film.title);

        //call DisplayInfo from Movie.cs
        film.DisplayInfo();

        //call Calculate Compatibility from Movie.cs
        film.CalculateCompatibility(favoriteGenre, leastFavoriteGenre, favoriteDecade);
           
    }

}
