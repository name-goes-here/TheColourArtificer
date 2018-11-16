using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragAndDrop : MonoBehaviour {

    private bool selected = false;
    Vector2 startPosition;
    public GameObject otherGameObject;
    public GameObject mixingBowl;

    void Start () {
        startPosition = transform.position;
	}
	
	void Update () {
        //object follows mouse
		if(selected == true) {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(mousePosition.x, mousePosition.y);
        }
        if (Input.GetMouseButtonUp(0)) {
            //check if user placed object in mixing bowl (colliders intersect)
            if (gameObject.GetComponent<Collider2D>().bounds.Intersects(mixingBowl.GetComponent<Collider2D>().bounds)) {
                //Counting how many things have been added
                otherGameObject.GetComponent<mixColors>().numOfAddedColors++;
                print(otherGameObject.GetComponent<mixColors>().numOfAddedColors);
                
                //FIX: Array does not exist anymore (addedColors)
                //Adding things to the "mixing bowl"
                /*otherGameObject.GetComponent<mixColors>().addedColors.Add(gameObject.name);
                foreach (var i in otherGameObject.GetComponent<mixColors>().addedColors) {
                    print(i);
                }*/
                //hide object
                gameObject.GetComponent<Renderer>().enabled = false;
            }

            selected = false;
            //object goes back to initial position
            transform.position = startPosition;
        }
	}

    void OnMouseDown() {
        selected = true;
    }
}
