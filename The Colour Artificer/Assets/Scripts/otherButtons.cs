using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class otherButtons : MonoBehaviour {

    public bool guidebookOpen = false;
    public GameObject guidebookButton;
    public GameObject guidebookWindow;
    public GameObject previous;
    public GameObject next;
    public int pageNum = 1;

    void Start () {
        
    }
	
	void Update () {
		
	}

    public void guidebookClick() {
        if (guidebookOpen) {
            //Gudiebook was open, so close it
            guidebookOpen = false;
            guidebookWindow.gameObject.SetActive(false);
            previous.gameObject.SetActive(false);
            next.gameObject.SetActive(false);
            guidebookButton.GetComponentInChildren<Text>().text = "Guidebook";
        } else {
            //Guidebook was closed, so open it
            guidebookOpen = true;
            guidebookWindow.gameObject.SetActive(true);
            previous.gameObject.SetActive(true);
            next.gameObject.SetActive(true);
            guidebookButton.GetComponentInChildren<Text>().text = "Close";
        }
    }

    public void previousPage() {
        if(pageNum > 1) {
            pageNum--;
            guidebookWindow.transform.Find(pageNum.ToString()).gameObject.SetActive(true);
            guidebookWindow.transform.Find((pageNum + 1).ToString()).gameObject.SetActive(false);
        }
    }

    public void nextPage() {
        if(pageNum < 3) {
            pageNum++;
            guidebookWindow.transform.Find(pageNum.ToString()).gameObject.SetActive(true);
            guidebookWindow.transform.Find((pageNum - 1).ToString()).gameObject.SetActive(false);
        }
    }
}
