using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mixColors : MonoBehaviour {
    
    //Counters
    public int numOfAddedColors = 0;
    public int numOfAddedMisc = 0;
    public string addedMisc = "None";
    public GameObject red, green, blue, love, power, equilibrium, stability, creation;
    public GameObject[] draggables;
    public Button mix;
    //Color newColor = Color.white;

    void Start () {
        creation.SetActive(false);
        draggables = GameObject.FindGameObjectsWithTag("Draggable");
    }
	
	void Update () {
        //Remove all other options if limit is reached
		if(numOfAddedColors > 1) {
            red.SetActive(false);
            green.SetActive(false);
            blue.SetActive(false);
        }
        if(numOfAddedMisc > 0) {
            love.SetActive(false);
            power.SetActive(false);
            equilibrium.SetActive(false);
            stability.SetActive(false);
        }
	}

    public void MixStuff() {
        //Create new colors
        if(numOfAddedColors > 1) {
            print("mix");
        }
    }
}
