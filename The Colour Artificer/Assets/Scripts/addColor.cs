using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addColor : MonoBehaviour {

    public GameObject otherGameObject;

    void Start () {
        
    }
	
	void Update () {
        
	}

    void OnMouseDown() {
        //Counting how many things have been added
        otherGameObject.GetComponent<mixColors>().numOfAddedColors++;
        print(otherGameObject.GetComponent<mixColors>().numOfAddedColors);

        //Adding things to the "mixing bowl"
        otherGameObject.GetComponent<mixColors>().addedColors.Add(gameObject.name);
        foreach (var i in otherGameObject.GetComponent<mixColors>().addedColors) {
            print(i);
        }
    }
}
