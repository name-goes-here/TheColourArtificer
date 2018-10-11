using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mixTest : MonoBehaviour {

    public GameObject redObject, blueObject, greenObject, mixObject;

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

        mixColours();
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
            Debug.Log("You have created magenta!");
        }

        else if (isRed == true && isGreen == true)
        {
            Debug.Log("You have created yellow!");
        }

        else if (isBlue == true && isGreen == true)
        {
            Debug.Log("You have created cyan!");
        }

        else
        {

        }
    }


}
