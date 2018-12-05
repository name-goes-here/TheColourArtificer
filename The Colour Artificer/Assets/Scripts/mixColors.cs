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
    public Color color1 = Color.white;
    public Color color2 = Color.white;
    public Color newColor = Color.white;
    //Existing yellow in Color structure is different from "normal" yellow, so I had to make my own yellow (stupid)
    Color yellow = new Color32(255, 255, 0, 255);

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
            //Mixes colors
            newColor = color1 + color2;
            //Set mixed color without abstract ingredients
            if (addedMisc == "None") {
                creation.GetComponent<Image>().color = newColor;
            } else {
                /*RGB values for colors with abstract ingredients don'r really correlate mathimetically
                 * (At least I couldn't find a pattern in the colors' RGB values)
                 * Therefore, these combinations had to be checked for manually
                 */
                if (compareColors(newColor, Color.magenta)) {
                    if (addedMisc == "Love") {
                        newColor = new Color32(255, 192, 203, 255); //Pink
                    } else if (addedMisc == "Power") {
                        newColor = new Color32(128, 0, 128, 255); //Purple
                    } else if (addedMisc == "Equilibrium") {
                        newColor = new Color32(230, 230, 250, 255); //Lavender
                    }
                } else if(compareColors(newColor, Color.cyan)) {
                    if (addedMisc == "Love") {
                        newColor = new Color32(128, 255, 212, 255); //Aquamarine
                    } else if (addedMisc == "Power") {
                        newColor = new Color32(0, 123, 167, 255); //Cerulean
                    } else if (addedMisc == "Equilibrium") {
                        newColor = new Color32(64, 224, 208, 255); //Turquoise
                    }
                } else if(compareColors(newColor, yellow)) {
                    if (addedMisc == "Love") {
                        newColor = new Color32(255, 203, 164, 255); //Peach
                    } else if (addedMisc == "Power") {
                        newColor = new Color32(255, 165, 0, 255); //Orange
                    } else if (addedMisc == "Stability") {
                        newColor = new Color32(255, 215, 0, 255); //Gold
                    }
                }
                creation.GetComponent<Image>().color = newColor;
            }
            creation.SetActive(true);
        }
    }

    //Compares two colors
    public bool compareColors(Color one, Color two) {
        if(Mathf.Approximately(one.r, two.r)) {
            if (Mathf.Approximately(one.g, two.g)) {
                if (Mathf.Approximately(one.b, two.b)) {
                    return true;
                }
            }
        }
        return false;
    }
}
