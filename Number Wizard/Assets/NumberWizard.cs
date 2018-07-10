using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{

    int max = 1000;
    int min = 1;
    int guess = 500;


    // Use this for initialization
    void Start()
    {
        StartGame();


    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = (max + min) / 2;
        Debug.Log("Welcome to number wizard \n Pick a number for the player to guess \n coucou");
        Debug.Log("The highest number is : " + max + " \n The lowest number is : " + min);

        Debug.Log("Tell me if your number is higher or lower than : " + guess);
        Debug.Log("Push Up Arrow if the number is HIGHER, Push Down Arrow if the number is LOWER, \n Push Enter if the number is CORRECT");

        max++;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("hm..kay, you're good");
            StartGame();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {

            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {

            min = guess;
            NextGuess();
        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is it higher or lower than " + guess);

    }

}
