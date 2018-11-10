﻿using System.Collections;
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
        //0 colors/misc added
        mix.GetComponent<mixColors>().numOfAddedColors = 0;
        mix.GetComponent<mixColors>().numOfAddedMisc = 0;
        mix.GetComponent<mixColors>().addedMisc = "None";
        //reset all objects again
        foreach (GameObject draggable in mix.GetComponent<mixColors>().draggables) {
            draggable.SetActive(true);
        }
    }
}
