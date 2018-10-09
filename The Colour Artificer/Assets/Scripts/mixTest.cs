using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mixTest : MonoBehaviour {

    public GameObject buttonObject;
    public Button buttonColour;

    public bool isRed, isBlue, isGreen;

    public addTest add;


    void Awake()
    {
        isRed = false;
        isBlue = false;
        isGreen = false;
    }

	// Use this for initialization
	void Start () {

        //addTest[] allComponents = FindObjectsOfType<addTest>();
        //foreach (addTest component in allComponents)
        //{
        //    component.enabled = false;
        //}
        isRed = false;
        isBlue = false;
        isGreen = false;
    }
	
	// Update is called once per frame
	void Update () {

		
        if (isRed == true && isBlue == true || isRed == true && isGreen == true || isBlue == true && isGreen == true)
        {

            addTest[] allComponents = FindObjectsOfType<addTest>();
            foreach (addTest component in allComponents)
            {
                component.enabled = false;
            }
        }

    }


}
