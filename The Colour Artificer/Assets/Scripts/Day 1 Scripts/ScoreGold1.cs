using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreGold1 : MonoBehaviour {

    public int requestCounter;
    public int goldCounter;

    public GameObject req, req1p, req1n, req2p, req2n, req3p, req3n, req4p, req4n, req5p, req5n, req6p, req6n, req7p, req7n;

    public GameObject storyDone;

    public Text goldText;

    public mixTest mix;

    void Awake()
    {
        goldText.text = "Gold = $" + goldCounter;
    }

	void Start () {

        mix.GetComponent<mixTest>();
        req.GetComponent<GameObject>();
        req1p.GetComponent<GameObject>();
        req1n.GetComponent<GameObject>();
        req2p.GetComponent<GameObject>();
        req2n.GetComponent<GameObject>();
        req3p.GetComponent<GameObject>();
        req3n.GetComponent<GameObject>();
        req4p.GetComponent<GameObject>();
        req4n.GetComponent<GameObject>();
        req5p.GetComponent<GameObject>();
        req5n.GetComponent<GameObject>();
        req6p.GetComponent<GameObject>();
        req6n.GetComponent<GameObject>();
        req7n.GetComponent<GameObject>();
        req7n.GetComponent<GameObject>();

    }

    void Update()
    {
        goldText.text = "Gold needed: $1300 / Current Gold = $" + goldCounter;
    }

    public void On_ButtonClick()
    {
        requestCounter = requestCounter + 1;
        StartGoldCount();
    }

    public void StartGoldCount()
    {
        if (requestCounter == 1)
        {
            if (mix.isCyan == true)
            {
                req1p.SetActive(true);
                goldCounter = goldCounter + 200;
                mix.enabled = false;
            }
            else if (mix.isCerulean == true || mix.isAquamarine == true || mix.isTurquoise == true)
            {
                mix.enabled = false;
                req1n.SetActive(true);
                goldCounter = goldCounter + 100;
            }
            else
            {
                mix.enabled = false;
                req1n.SetActive(true);
                goldCounter = goldCounter + 50;

            }
        }

        else if (requestCounter == 2)
        {
            if (mix.isCerulean == true)
            {
                mix.enabled = false;
                req2p.SetActive(true);
                goldCounter = goldCounter + 200;
            }
            else if (mix.isCerulean == true || mix.isAquamarine == true || mix.isTurquoise == true)
            {
                mix.enabled = false;
                req2n.SetActive(true);
                goldCounter = goldCounter + 100;
            }
            else
            {
                mix.enabled = false;
                req2n.SetActive(true);
                goldCounter = goldCounter + 50;
            }
        }
        else if (requestCounter == 3)
        {
            if (mix.isYellow == true)
            {
                mix.enabled = false;
                req3p.SetActive(true);
                goldCounter = goldCounter + 200;
            }
            else if (mix.isPeach == true || mix.isGold == true || mix.isOrange == true)
            {
                mix.enabled = false;
                req3n.SetActive(true);
                goldCounter = goldCounter + 100;
            }
            else
            {
                mix.enabled = false;
                req3n.SetActive(true);
                goldCounter = goldCounter + 50;
            }
        }
        else if (requestCounter == 4)
        {
            if (mix.isPurple == true)
            {
                mix.enabled = false;
                req4p.SetActive(true);
                goldCounter = goldCounter + 200;
            }
            else if (mix.isPink == true || mix.isLavender == true || mix.isMagenta == true)
            {
                mix.enabled = false;
                req4n.SetActive(true);
                goldCounter = goldCounter + 100;
            }
            else
            {
                mix.enabled = false;
                req4n.SetActive(true);
                goldCounter = goldCounter + 50;
            }
        }
        else if (requestCounter == 5)
        {
            if (mix.isPurple == true || mix.isMagenta == true || mix.isLavender == true)
            {
                mix.enabled = false;
                req5p.SetActive(true);
                goldCounter = goldCounter + 200;
            }
            else if (mix.isPink == true)
            {
                mix.enabled = false;
                req5n.SetActive(true);
                goldCounter = goldCounter + 100;
            }
            else
            {
                mix.enabled = false;
                req5n.SetActive(true);
                goldCounter = goldCounter + 50;
            }
        }
        else if (requestCounter == 6)
        {
            if (mix.isPeach == true)
            {
                mix.enabled = false;
                req6p.SetActive(true);
                goldCounter = goldCounter + 200;
            }
            else if (mix.isYellow == true)
            {
                mix.enabled = false;
                req6n.SetActive(true);
                goldCounter = goldCounter + 100;
            }
            else
            {
                mix.enabled = false;
                req6n.SetActive(true);
                goldCounter = goldCounter + 50;
            }
        }
        else if (requestCounter == 7)
        {
            if (mix.isYellow == true)
            {
                mix.enabled = false;
                req7p.SetActive(true);
                goldCounter = goldCounter + 200;
            }
            else if (mix.isGold == true || mix.isOrange == true)
            {
                mix.enabled = false;
                req7n.SetActive(true);
                goldCounter = goldCounter + 100;
            }
            else
            {
                mix.enabled = false;
                req7n.SetActive(true);
                goldCounter = goldCounter + 50;
            }
        }
    }
	
}
