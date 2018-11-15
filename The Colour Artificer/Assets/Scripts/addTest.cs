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
        mix.enabled = true;
        mix.isRed = true;
        mix.isMagenta = false;
        mix.isCyan = false;
        mix.isYellow = false;
        mix.isPink = false;
        mix.isPurple = false;
        mix.isLavender = false;
        mix.isTurquoise = false;
        mix.isCerulean = false;
        mix.isAquamarine = false;
        mix.isGold = false;
        mix.isOrange = false;
        mix.isPeach = false;
        mix.isElation = false;
        mix.isEnergy = false;
        mix.isEquilibrium = false;
        otherObject.SetActive(false);
    }

    public void blueButton_Click()
    {
        mix.enabled = true;
        mix.isBlue = true;
        mix.isMagenta = false;
        mix.isCyan = false;
        mix.isYellow = false;
        mix.isPink = false;
        mix.isPurple = false;
        mix.isLavender = false;
        mix.isTurquoise = false;
        mix.isCerulean = false;
        mix.isAquamarine = false;
        mix.isGold = false;
        mix.isOrange = false;
        mix.isPeach = false;
        otherObject.SetActive(false);
    }

    public void greenButton_Click()
    {
        mix.enabled = true;
        mix.isGreen = true;
        mix.isMagenta = false;
        mix.isCyan = false;
        mix.isYellow = false;
        mix.isPink = false;
        mix.isPurple = false;
        mix.isLavender = false;
        mix.isTurquoise = false;
        mix.isCerulean = false;
        mix.isAquamarine = false;
        mix.isGold = false;
        mix.isOrange = false;
        mix.isPeach = false;
        otherObject.SetActive(false);
    }

    public void elationButton()
    {
        mix.isElation = true;
        mix.isMagenta = false;
        mix.isCyan = false;
        mix.isYellow = false;
        otherObject.SetActive(false);
    }

    public void energyButton()
    {
        mix.isEnergy = true;
        mix.isMagenta = false;
        mix.isCyan = false;
        mix.isYellow = false;
        otherObject.SetActive(false);
    }

    public void equilibriumButton()
    {
        mix.isEquilibrium = true;
        mix.isMagenta = false;
        mix.isCyan = false;
        mix.isYellow = false;
        otherObject.SetActive(false);
    }
}
