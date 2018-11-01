using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reset : MonoBehaviour {

    public GameObject mix;
    public Button reset;

	void Start () {
		
	}
	
	void Update () {
		
	}

    public void ButtonReset() { 
        print("Reset");
        //0 colors added
        mix.GetComponent<mixColors>().numOfAddedColors = 0;
        //remove all colors from mixing bowl
        mix.GetComponent<mixColors>().addedColors.Clear();
        //show all objects again
        mix.GetComponent<mixColors>().red.SetActive(true);
        mix.GetComponent<mixColors>().green.SetActive(true);
        mix.GetComponent<mixColors>().blue.SetActive(true);
        /*
         *For Sprites
        mix.GetComponent<mixColors>().red.GetComponent<Renderer>().enabled = true;
        mix.GetComponent<mixColors>().green.GetComponent<Renderer>().enabled = true;
        mix.GetComponent<mixColors>().blue.GetComponent<Renderer>().enabled = true;
        */
    }
}
