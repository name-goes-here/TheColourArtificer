using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class dragButton : MonoBehaviour, IDragHandler, IEndDragHandler {

    Vector2 startPotsition;
    public GameObject mix;
    public GameObject mixingBowl;

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
        if (gameObject.GetComponent<Collider2D>().bounds.Intersects(mixingBowl.GetComponent<Collider2D>().bounds)) {
            //Counting how many things have been added
            mix.GetComponent<mixColors>().numOfAddedColors++;

            //Adding things to the "mixing bowl"
            mix.GetComponent<mixColors>().addedColors.Add(gameObject.name);
            gameObject.SetActive(false);
        }
        transform.position = startPotsition;
    }
}
