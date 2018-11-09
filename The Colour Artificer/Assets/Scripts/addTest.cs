using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class addTest : MonoBehaviour {

    public GameObject otherObject;
    public Button colourButton;

    public mixTest mix;

    // Use this for initialization
    void Start () { 

        mix.GetComponent<mixTest>();
        otherObject.GetComponent<GameObject>();
        colourButton.GetComponent<Button>();
    }

    // Called after pressing a button
    public void redButton_Click()
    {
        mix.isRed = true;
        otherObject.SetActive(false);
    }

    public void blueButton_Click()
    {
        mix.isBlue = true;
        otherObject.SetActive(false);
    }

    public void greenButton_Click()
    {
        mix.isGreen = true;
        otherObject.SetActive(false);
    }
}
