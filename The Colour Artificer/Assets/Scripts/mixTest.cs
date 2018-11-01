using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mixTest : MonoBehaviour {

    public GameObject redObject, blueObject, greenObject, mixObject, yes, no, elaObject, enObject, eqObject;
    public Text mixText;

    public bool isRed, isBlue, isGreen, isMagenta, isCyan, isYellow, isElation, isEnergy, isEquilibrium;
    public bool isPink, isPurple, isLavender, isTurquoise, isCerulean, isAquamarine, isOrange, isPeach, isGold;

    public addTest add;

    // Use this for initialization
    void Start()
    {

        isRed = false;
        isBlue = false;
        isGreen = false;
        isMagenta = false;
        isCyan = false;
        isYellow = false;
        isElation = false;
        isEnergy = false;
        isEquilibrium = false;

        redObject.GetComponent<GameObject>();
        blueObject.GetComponent<GameObject>();
        greenObject.GetComponent<GameObject>();
        mixObject.GetComponent<GameObject>();
        elaObject.GetComponent<GameObject>();
        enObject.GetComponent<GameObject>();
        eqObject.GetComponent<GameObject>();
        yes.GetComponent<GameObject>();
        no.GetComponent<GameObject>();

        mixColours();
        mixText.text = "";

        yes.SetActive(false);
        no.SetActive(false);
    }

    // Update is called once per frame
    void Update() {


        if (isRed == true && isBlue == true || isRed == true && isGreen == true || isBlue == true && isGreen == true)
        {
            redObject.SetActive(false);
            blueObject.SetActive(false);
            greenObject.SetActive(false);

        }

        if (isElation == true || isEnergy == true || isEquilibrium == true)
        {
            elaObject.SetActive(false);
            enObject.SetActive(false);
            eqObject.SetActive(false);
        }

    }

    public void mixColours()
    {
        if (isRed == true && isBlue == true && isElation == false && isEnergy == false && isEquilibrium == false)
        {
            mixObject.SetActive(false);
            mixText.text = "You have created magenta! Would you like to submit this colour?";
            isMagenta = true;
            yes.SetActive(true);
            no.SetActive(true);
            elaObject.SetActive(false);
            enObject.SetActive(false);
            eqObject.SetActive(false);
        }

        else if (isRed == true && isGreen == true && isElation == false && isEnergy == false && isEquilibrium == false)
        {
            mixObject.SetActive(false);
            mixText.text = "You have created yellow! Would you like to submit this colour?";
            isYellow = true;
            yes.SetActive(true);
            no.SetActive(true);
            elaObject.SetActive(false);
            enObject.SetActive(false);
            eqObject.SetActive(false);
        }

        else if (isBlue == true && isGreen == true && isElation == false && isEnergy == false && isEquilibrium == false)
        {
            mixObject.SetActive(false);
            mixText.text = "You have created cyan! Would you like to submit this colour?";
            isCyan = true;
            yes.SetActive(true);
            no.SetActive(true);
            elaObject.SetActive(false);
            enObject.SetActive(false);
            eqObject.SetActive(false);
        }

        else if (isRed == true && isBlue == true && isElation == true)
        {
            mixObject.SetActive(false);
            mixText.text = "You have created pink! Would you like to submit this colour?";
            isPink = true;
            yes.SetActive(true);
            no.SetActive(true);
            elaObject.SetActive(false);
            enObject.SetActive(false);
            eqObject.SetActive(false);
        }

        else if (isRed == true && isBlue == true && isEnergy == true)
        {
            mixObject.SetActive(false);
            mixText.text = "You have created purple! Would you like to submit this colour?";
            isPurple = true;
            yes.SetActive(true);
            no.SetActive(true);
            elaObject.SetActive(false);
            enObject.SetActive(false);
            eqObject.SetActive(false);
        }

        else if (isRed == true && isBlue == true && isEquilibrium == true)
        {
            mixObject.SetActive(false);
            mixText.text = "You have created lavender! Would you like to submit this colour?";
            isLavender = true;
            yes.SetActive(true);
            no.SetActive(true);
            elaObject.SetActive(false);
            enObject.SetActive(false);
            eqObject.SetActive(false);
        }

        else if (isRed == true && isGreen == true && isElation == true)
        {
            mixObject.SetActive(false);
            mixText.text = "You have created peach! Would you like to submit this colour?";
            isPeach = true;
            yes.SetActive(true);
            no.SetActive(true);
            elaObject.SetActive(false);
            enObject.SetActive(false);
            eqObject.SetActive(false);
        }

        else if (isRed == true && isGreen == true && isEnergy == true)
        {
            mixObject.SetActive(false);
            mixText.text = "You have created orange! Would you like to submit this colour?";
            isOrange = true;
            yes.SetActive(true);
            no.SetActive(true);
            elaObject.SetActive(false);
            enObject.SetActive(false);
            eqObject.SetActive(false);
        }

        else if (isRed == true && isGreen == true && isEquilibrium == true)
        {
            mixObject.SetActive(false);
            mixText.text = "You have created gold! Would you like to submit this colour?";
            isGold = true;
            yes.SetActive(true);
            no.SetActive(true);
            elaObject.SetActive(false);
            enObject.SetActive(false);
            eqObject.SetActive(false);
        }

        else if (isBlue == true && isGreen == true && isElation == true)
        {
            mixObject.SetActive(false);
            mixText.text = "You have created aquamarine! Would you like to submit this colour?";
            isAquamarine = true;
            yes.SetActive(true);
            no.SetActive(true);
            elaObject.SetActive(false);
            enObject.SetActive(false);
            eqObject.SetActive(false);
        }

        else if (isBlue == true && isGreen == true && isEnergy == true)
        {
            mixObject.SetActive(false);
            mixText.text = "You have created cerulean! Would you like to submit this colour?";
            isCerulean = true;
            yes.SetActive(true);
            no.SetActive(true);
            elaObject.SetActive(false);
            enObject.SetActive(false);
            eqObject.SetActive(false);
        }

        else if (isBlue == true && isGreen == true && isEquilibrium == true)
        {
            mixObject.SetActive(false);
            mixText.text = "You have created turquoise! Would you like to submit this colour?";
            isTurquoise = true;
            yes.SetActive(true);
            no.SetActive(true);
            elaObject.SetActive(false);
            enObject.SetActive(false);
            eqObject.SetActive(false);
        }

        else
        {
            mixText.text = "You have not made a proper colour!";
        }


    }


}
