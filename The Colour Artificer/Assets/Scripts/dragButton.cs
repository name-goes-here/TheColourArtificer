using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class dragButton : MonoBehaviour, IDragHandler, IEndDragHandler {

    Vector2 startPotsition;
    public GameObject colour;
    public GameObject mixingBowl;

    public int colourValue;

    public mixTest mix;

    void Start () {

        startPotsition = transform.position;

        colour.GetComponent<GameObject>();
        mixingBowl.GetComponent<GameObject>();

	}
	
	void Update () {
        
    }

    //Object follows mouse
    public void OnDrag(PointerEventData eventData) {
        transform.position = Input.mousePosition;
    }

    //Drag ended
    public void OnEndDrag(PointerEventData eventData) {
        if (colour.GetComponent<Collider2D>().bounds.Intersects(mixingBowl.GetComponent<Collider2D>().bounds)) {

            if(colourValue == 1)
            {
                mix.isRed = true;
                mix.isMagenta = false;
                mix.isCyan = false;
                mix.isYellow = false;
                mix.isPink = false;
                mix.isPurple = false;
                mix.isLavender = false;
                mix.isTurquoise = false;
                mix.isCerulean = false;
                mix.isAquamarine = false;
                mix.isGold = false;
                mix.isOrange = false;
                mix.isPeach = false;
                mix.isElation = false;
                mix.isEnergy = false;
                mix.isEquilibrium = false;
                colour.SetActive(false);
            }

            else if (colourValue == 2)
            {
                mix.isBlue = true;
                mix.isMagenta = false;
                mix.isCyan = false;
                mix.isYellow = false;
                mix.isPink = false;
                mix.isPurple = false;
                mix.isLavender = false;
                mix.isTurquoise = false;
                mix.isCerulean = false;
                mix.isAquamarine = false;
                mix.isGold = false;
                mix.isOrange = false;
                mix.isPeach = false;
                mix.isElation = false;
                mix.isEnergy = false;
                mix.isEquilibrium = false;
                colour.SetActive(false);
            }

            else if (colourValue == 3)
            {
                mix.isGreen = true;
                mix.isMagenta = false;
                mix.isCyan = false;
                mix.isYellow = false;
                mix.isPink = false;
                mix.isPurple = false;
                mix.isLavender = false;
                mix.isTurquoise = false;
                mix.isCerulean = false;
                mix.isAquamarine = false;
                mix.isGold = false;
                mix.isOrange = false;
                mix.isPeach = false;
                mix.isElation = false;
                mix.isEnergy = false;
                mix.isEquilibrium = false;
                colour.SetActive(false);
            }

            else if (colourValue == 4)
            {
                mix.isMagenta = false;
                mix.isCyan = false;
                mix.isYellow = false;
                mix.isPink = false;
                mix.isPurple = false;
                mix.isLavender = false;
                mix.isTurquoise = false;
                mix.isCerulean = false;
                mix.isAquamarine = false;
                mix.isGold = false;
                mix.isOrange = false;
                mix.isPeach = false;
                mix.isElation = true;
                mix.isEnergy = false;
                mix.isEquilibrium = false;
                colour.SetActive(false);
            }

            else if (colourValue == 5)
            {
                mix.isGreen = true;
                mix.isMagenta = false;
                mix.isCyan = false;
                mix.isYellow = false;
                mix.isPink = false;
                mix.isPurple = false;
                mix.isLavender = false;
                mix.isTurquoise = false;
                mix.isCerulean = false;
                mix.isAquamarine = false;
                mix.isGold = false;
                mix.isOrange = false;
                mix.isPeach = false;
                mix.isElation = false;
                mix.isEnergy = true;
                mix.isEquilibrium = false;
                colour.SetActive(false);
            }

            else if (colourValue == 6)
            {
                mix.isGreen = true;
                mix.isMagenta = false;
                mix.isCyan = false;
                mix.isYellow = false;
                mix.isPink = false;
                mix.isPurple = false;
                mix.isLavender = false;
                mix.isTurquoise = false;
                mix.isCerulean = false;
                mix.isAquamarine = false;
                mix.isGold = false;
                mix.isOrange = false;
                mix.isPeach = false;
                mix.isElation = false;
                mix.isEnergy = false;
                mix.isEquilibrium = true;
                colour.SetActive(false);
            }
        }
        transform.position = startPotsition;
    }
}
