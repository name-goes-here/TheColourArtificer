using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class larpingFinal : MonoBehaviour {

    public mixTest mix;
    public Color color1 = Color.white;
    public Color color2 = Color.white;
    public Color finalColor = Color.white;
    public GameObject colourDisplay;



	// Use this for initialization
	void Start () {
        colourDisplay.GetComponent<GameObject>();
        mix.GetComponent<mixTest>();
	}
	
	// Update is called once per frame
	void Update () {
        colourDisplay.GetComponent<Image>().color = finalColor;
    }

    public void ChangeColour()
    {
        if (mix.isMagenta == true)
        {
            finalColor = new Color32(255, 0, 255, 255);
        }

        else if (mix.isCyan == true)
        {
            finalColor = new Color32(0, 255, 255, 255);
        }

        else if (mix.isYellow == true)
        {
            finalColor = new Color32(255, 255, 0, 255);
        }

        else if (mix.isPink == true)
        {
            finalColor = new Color32(255, 192, 203, 255);
        }

        else if (mix.isPurple == true)
        {
            finalColor = new Color32(128, 0, 128, 255);
        }

        else if (mix.isLavender == true)
        {
            finalColor = new Color32(230, 230, 250, 255);
        }

        else if (mix.isTurquoise == true)
        {
            finalColor = new Color32(64, 244, 208, 255);
        }

        else if (mix.isCerulean == true)
        {
            finalColor = new Color32(0, 123, 167, 255);
        }

        else if (mix.isAquamarine == true)
        {
            finalColor = new Color32(127, 255, 212, 255);
        }

        else if (mix.isOrange == true)
        {
            finalColor = new Color32(255, 165, 0, 255);
        }

        else if (mix.isPeach == true)
        {
            finalColor = new Color32(255, 229, 180, 255);
        }

        else if (mix.isGold== true)
        {
            finalColor = new Color32(255, 215, 0, 255);
        }

        colourDisplay.GetComponent<Image>().color = finalColor;
    }
}
