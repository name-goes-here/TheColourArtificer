using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour {

    public GameObject otherGameObject;

	void Start () {
		
	}
	
	void Update () {
		
	}

    private void OnMouseDown() {
        print("Reset");
        //0 colors added
        otherGameObject.GetComponent<mixColors>().numOfAddedColors = 0;
        //remove all colors from mixing bowl
        otherGameObject.GetComponent<mixColors>().addedColors.Clear();
        //show all objects again
        otherGameObject.GetComponent<mixColors>().red.GetComponent<Renderer>().enabled = true;
        otherGameObject.GetComponent<mixColors>().green.GetComponent<Renderer>().enabled = true;
        otherGameObject.GetComponent<mixColors>().blue.GetComponent<Renderer>().enabled = true;
    }
}
