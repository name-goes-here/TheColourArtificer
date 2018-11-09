using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mixTest : MonoBehaviour {

    public GameObject redObject, blueObject, greenObject, mixObject,yes,no;
    public Text mixText;

    public bool isRed, isBlue, isGreen;

    public addTest add;

	// Use this for initialization
	void Start () {

        isRed = false;
        isBlue = false;
        isGreen = false;

        redObject.GetComponent<GameObject>();
        blueObject.GetComponent<GameObject>();
        greenObject.GetComponent<GameObject>();
        mixObject.GetComponent<GameObject>();
        yes.GetComponent<GameObject>();
        mixObject.GetComponent<GameObject>();
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
        yes.SetActive(true);
        no.SetActive(true);

        if (isRed == true && isBlue == true)
        {
            mixObject.SetActive(false);
            Debug.Log("You have created magenta!");
            mixText.text = "You have created magenta! Would you like to submit this colour?";
        }

        else if (isRed == true && isGreen == true)
        {
            mixObject.SetActive(false);
            Debug.Log("You have created yellow!");
            mixText.text = "You have created yellow! Would you like to submit this colour?";
        }

        else if (isBlue == true && isGreen == true)
        {
            mixObject.SetActive(false);
            Debug.Log("You have created cyan!");
            mixText.text = "You have created cyan! Would you like to submit this colour?";
        }

        else
        {

        }
    }


}
