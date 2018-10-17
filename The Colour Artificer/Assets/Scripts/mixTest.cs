using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mixTest : MonoBehaviour {

    public GameObject redObject, blueObject, greenObject, mixObject,yes,no;
    public Text mixText;

    public bool isRed, isBlue, isGreen, isMagenta, isCyan, isYellow;

    public addTest add;

	// Use this for initialization
	void Start () {

        isRed = false;
        isBlue = false;
        isGreen = false;
        isMagenta = false;
        isCyan = false;
        isYellow = false;

        redObject.GetComponent<GameObject>();
        blueObject.GetComponent<GameObject>();
        greenObject.GetComponent<GameObject>();
        mixObject.GetComponent<GameObject>();
        yes.GetComponent<GameObject>();
        no.GetComponent<GameObject>();

        mixColours();
        mixText.text = "";

        yes.SetActive(false);
        no.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {

		
        if (isRed == true && isBlue == true || isRed == true && isGreen == true || isBlue == true && isGreen == true)
        {
            redObject.SetActive(false);
            blueObject.SetActive(false);
            greenObject.SetActive(false);

        }

    }

    public void mixColours()
    {

        if (isRed == true && isBlue == true)
        {
            mixObject.SetActive(false);
            mixText.text = "You have created magenta! Would you like to submit this colour?";
            isMagenta = true;
            yes.SetActive(true);
            no.SetActive(true);
        }

        else if (isRed == true && isGreen == true)
        {
            mixObject.SetActive(false);
            mixText.text = "You have created yellow! Would you like to submit this colour?";
            isYellow = true;
            yes.SetActive(true);
            no.SetActive(true);
        }

        else if (isBlue == true && isGreen == true)
        {
            mixObject.SetActive(false);
            mixText.text = "You have created cyan! Would you like to submit this colour?";
            isCyan = true;
            yes.SetActive(true);
            no.SetActive(true);
        }

        else
        {
            mixText.text = "You have not made a proper colour!";
        }
    }


}
