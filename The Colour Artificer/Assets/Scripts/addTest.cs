using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class addTest : MonoBehaviour {

    public GameObject otherObject;
    public Button colourButton;
    public Text firstText, secondText, mixText;
    //public bool isRed, isBlue, isGreen;
    //public bool redOff, blueOff, greenOff;

    public mixTest mix;

    // Use this for initialization
    void Start () {
        mixText.text = "Please choose 2 colours";

        //will deactivate all "addTest2" scripts from all objects that carry it
        //mixTest[] allComponents = FindObjectsOfType<mixTest>();
        //foreach (mixTest component in allComponents)
        //{
        //    component.enabled = false;
        //}

        //redOff = false;
        //blueOff = false;
        //greenOff = false;

        mix = GetComponent<mixTest>();

        colourButton = GetComponent<Button>();
    }

    // Called after pressing a button
    public void redButton_Click()
    {
        //firstText.text = "You have chosen red!";
        mix.isRed = true;

        colourButton.GetComponent<Button>().interactable = false;

        //will activate all "mixTest" scripts from all objects that carry it
        mixTest[] allComponents = FindObjectsOfType<mixTest>();
        foreach (mixTest component in allComponents)
        {
            component.enabled = true;

        }
    }

    public void blueButton_Click()
    {
        //firstText.text = "You have chosen blue!";
        mix.isBlue = true;
        colourButton.GetComponent<Button>().interactable = false;

        //will activate all "mixTest" scripts from all objects that carry it
        mixTest[] allComponents = FindObjectsOfType<mixTest>();
        foreach (mixTest component in allComponents)
        {
            component.enabled = true;

        }
    }

    public void greenButton_Click()
    {
        //firstText.text = "You have chosen green!";
        mix.isGreen = true;
        colourButton.GetComponent<Button>().interactable = false;

        //will activate all "mixTest" scripts from all objects that carry it
        mixTest[] allComponents = FindObjectsOfType<mixTest>();
        foreach (mixTest component in allComponents)
        {
            component.enabled = true;

        }
    }
}
