﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class newDragButton : MonoBehaviour, IDragHandler, IEndDragHandler {

    Vector2 startPotsition;
    public GameObject mix;
    public GameObject mixingBowl;
    string[] colors = new string[] { "red", "green", "blue" };

    void Start() {
        startPotsition = transform.position;
    }

    //Object follows mouse
    public void OnDrag(PointerEventData eventData) {
        transform.position = Input.mousePosition;
    }

    //Drag ended
    public void OnEndDrag(PointerEventData eventData) {
        //Over mixing pot
        if (gameObject.GetComponent<Collider2D>().bounds.Intersects(mixingBowl.GetComponent<Collider2D>().bounds)) {
            //Was a color added
            if (System.Array.IndexOf(colors, gameObject.name.ToLower()) > -1) {
                mix.GetComponent<mixColors>().numOfAddedColors++;
                //First or second color
                if (mix.GetComponent<mixColors>().numOfAddedColors == 1) {
                    mix.GetComponent<mixColors>().color1 = gameObject.GetComponent<Image>().color;
                } else if (mix.GetComponent<mixColors>().numOfAddedColors == 2) {
                    mix.GetComponent<mixColors>().color2 = gameObject.GetComponent<Image>().color;
                }
            } else {
                mix.GetComponent<mixColors>().numOfAddedMisc++;
                mix.GetComponent<mixColors>().addedMisc = gameObject.name;
            }
            gameObject.SetActive(false);
        }
        transform.position = startPotsition;
    }
}