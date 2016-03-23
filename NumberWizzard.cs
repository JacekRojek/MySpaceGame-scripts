using UnityEngine;
using System.Collections;

public class NumberWizzard : MonoBehaviour {
    int max ;
    int min ;
    int guess ;
    // Use this for initialization
    void Start () {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        max++;
        print("===============");
        print("Pick a number!");

        print("Max value is " + max);
        print("Min value is " + min);
        print("is the value lower than " + guess);
        print("highier arrow more, lower less, return for equals ");
    }
	void NextGuess()
    {
        guess = (max + min) / 2;
        print("higher or lower than " + guess);
    }
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //print("Up arrow pressed");
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            // print("Down arrow pressed");
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("I won");
            StartGame();
        }
    }
}
