using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mixColors : MonoBehaviour {
    
    //includes other elemnts besides colors
    public int numOfAddedColors = 0;
    public ArrayList addedColors = new ArrayList();
    public GameObject red, green, blue;
    public Button mix;

    void Start () {
		
	}
	
	void Update () {
		
	}

    public void MixStuff() {
        //Formula to create new colors
        if(numOfAddedColors > 1) {
            //ADD formula
            print("Mix");
        }
    }
}
