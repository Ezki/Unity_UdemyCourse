using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int max = 1000;
        int min = 0;
        int half = max;


        Debug.Log("Welcome to number wizard \n Pick a number for the player to guess \n coucou");
        Debug.Log("The highest number is : " + max +" \n The lowest number is : " + min);

        Debug.Log("Tell me if your number is higher or lower than : " + half);
        Debug.Log("Push up = higher, Push Down = Lower, Push Enter = Correct");



    }
	
	// Update is called once per frame
	void Update () {


        if (Input.GetKeyDown(KeyCode.Return))
            Debug.Log("Enter key was pressed.");
        if (Input.GetKeyDown(KeyCode.DownArrow))
            Debug.Log("down was pressed.");
        if (Input.GetKeyDown(KeyCode.UpArrow))
            Debug.Log("up was pressed.");
    }
}
