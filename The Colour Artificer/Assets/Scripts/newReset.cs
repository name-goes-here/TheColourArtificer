using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class newReset : MonoBehaviour {

    public GameObject mix;
    public Button reset;

    void Start() {

    }

    void Update() {

    }

    public void ButtonReset() {
        //0 colors/misc added
        mix.GetComponent<mixColors>().numOfAddedColors = 0;
        mix.GetComponent<mixColors>().numOfAddedMisc = 0;
        mix.GetComponent<mixColors>().addedMisc = "None";
        //Reset all draggable objects
        foreach (GameObject draggable in mix.GetComponent<mixColors>().draggables) {
            draggable.SetActive(true);
        }
        //Reset created (mixed) color
        mix.GetComponent<mixColors>().creation.SetActive(false);
    }
}
