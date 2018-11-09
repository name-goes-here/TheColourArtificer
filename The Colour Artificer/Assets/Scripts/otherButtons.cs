using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class otherButtons : MonoBehaviour {

    public bool guidebookOpen = false;
    public GameObject guidebookButton;
    public GameObject guidebookWindow;

    void Start () {
        guidebookWindow.gameObject.SetActive(false);
    }
	
	void Update () {
		
	}

    public void guidebook_click() {
        if (guidebookOpen) {
            //Gudiebook was open, so close it
            guidebookOpen = false;
            guidebookWindow.gameObject.SetActive(false);
            guidebookButton.GetComponentInChildren<Text>().text = "Gudiebook";
        } else {
            //Guidebook was closed, so open it
            guidebookOpen = true;
            guidebookWindow.gameObject.SetActive(true);
            guidebookButton.GetComponentInChildren<Text>().text = "Close";
        }
    }
}
