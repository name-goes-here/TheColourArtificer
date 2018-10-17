using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YesRestart : MonoBehaviour {

    public GameObject redButton;
    public GameObject blueButton;
    public GameObject greenButton;
    public GameObject mixButton;

    public mixTest mix;

    // Use this for initialization
    void Start () {

        redButton.GetComponent<GameObject>();
        blueButton.GetComponent<GameObject>();
        greenButton.GetComponent<GameObject>();
        mixButton.GetComponent<GameObject>();

        mix.GetComponent<mixTest>();

    }

    public void On_ButtonClick()
    {
        mix.mixText.text = "";
        mix.isRed = false;
        mix.isBlue = false;
        mix.isGreen = false;
    }
	
}
