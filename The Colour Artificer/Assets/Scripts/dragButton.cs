using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class dragButton : MonoBehaviour, IDragHandler, IEndDragHandler {

    Vector2 startPotsition;
    public GameObject mix;
    public GameObject mixingBowl;
    string[] colors = new string[]{ "red", "green", "blue" };

    void Start () {
        startPotsition = transform.position;
    }
	
	void Update () {
        
    }

    //Object follows mouse
    public void OnDrag(PointerEventData eventData) {
        transform.position = Input.mousePosition;
    }

    //Drag ended
    public void OnEndDrag(PointerEventData eventData) {
        //Over mixing pot
        if (gameObject.GetComponent<Collider2D>().bounds.Intersects(mixingBowl.GetComponent<Collider2D>().bounds)) {
            //Counting how many things have been added
            if(System.Array.IndexOf(colors, gameObject.name.ToLower()) > -1) {
                mix.GetComponent<mixColors>().numOfAddedColors++;
            } else {
                mix.GetComponent<mixColors>().numOfAddedMisc++;
                mix.GetComponent<mixColors>().addedMisc = gameObject.name;
            }
            gameObject.SetActive(false);
        }
        //Return to starting position
        transform.position = startPotsition;
    }
}
