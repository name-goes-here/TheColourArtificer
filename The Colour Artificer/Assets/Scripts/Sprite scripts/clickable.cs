using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickable : MonoBehaviour {

    public Color startColor;

    void Start () {
        startColor = GetComponent<SpriteRenderer>().color;
    }
	
	void Update () {
		
	}

    void OnMouseEnter() {
        GetComponent<SpriteRenderer>().color = new Color(.8f, .8f, .8f);
    }

    void OnMouseExit() {
        GetComponent<SpriteRenderer>().color = startColor;
    }
}
