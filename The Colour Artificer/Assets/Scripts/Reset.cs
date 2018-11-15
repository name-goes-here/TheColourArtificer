using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reset : MonoBehaviour {

    //public GameObject mix;
    //public Button reset;
    public GameObject red, blue, green, elation, energy, equilibrium, yes, no, mixB;

    public mixTest mix;

    public Text mixText;

    void Start () {
        mix.GetComponent<mixTest>();

        red.GetComponent<GameObject>();
        blue.GetComponent<GameObject>();
        green.GetComponent<GameObject>();
        elation.GetComponent<GameObject>();
        energy.GetComponent<GameObject>();
        equilibrium.GetComponent<GameObject>();
        yes.GetComponent<GameObject>();
        no.GetComponent<GameObject>();
        mixB.GetComponent<GameObject>();
    }
	
	void Update () {
		
	}

    public void ButtonReset() {
        //0 colors added
        //mix.GetComponent<mixColors>().numOfAddedColors = 0;
        //remove all colors from mixing bowl
        //mix.GetComponent<mixColors>().addedColors.Clear();
        //show all objects again
        //mix.GetComponent<mixColors>().red.SetActive(true);
        //mix.GetComponent<mixColors>().green.SetActive(true);
        //mix.GetComponent<mixColors>().blue.SetActive(true);
        /*
         *For Sprites
        mix.GetComponent<mixColors>().red.GetComponent<Renderer>().enabled = true;
        mix.GetComponent<mixColors>().green.GetComponent<Renderer>().enabled = true;
        mix.GetComponent<mixColors>().blue.GetComponent<Renderer>().enabled = true;
        */

        red.SetActive(true);
        blue.SetActive(true);
        green.SetActive(true);
        elation.SetActive(true);
        energy.SetActive(true);
        equilibrium.SetActive(true);

        mix.enabled = true;
        mix.isRed = false;
        mix.isBlue = false;
        mix.isGreen = false;
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

        mixText.text = "";
        yes.SetActive(false);
        no.SetActive(false);
        mixB.SetActive(true);

    }
}
