using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class HannouManeger : MonoBehaviour {

    public static int colnumber;        // The player's score.


   // Text text;                      // Reference to the Text component.


    void Awake()
    {
        // Set up the reference.
    //    text = GetComponent<Text>();

        // Reset the score.
        colnumber = 0;
    }


    void Update()
    {
        // Set the displayed text to be the word "Score" followed by the score value.
   //     text.text = "DAMAGE= " + colnumber;

    }
}
