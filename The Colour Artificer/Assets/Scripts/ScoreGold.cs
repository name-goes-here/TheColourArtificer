using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreGold : MonoBehaviour {

    public int requestCounter;
    public int goldCounter;

    public GameObject req, req1perfect, req1imperfect, req2imperfect, req2perfect;

    public Text goldText;

    public mixTest mix;

    void Awake()
    {
        goldText.text = "Gold = $" + goldCounter;
    }

	void Start () {

        mix.GetComponent<mixTest>();
        req.GetComponent<GameObject>();
        req1perfect.GetComponent<GameObject>();
        req1imperfect.GetComponent<GameObject>();
        req2imperfect.GetComponent<GameObject>();
        req2perfect.GetComponent<GameObject>();

    }

    void Update()
    {
        goldText.text = "Gold = $" + goldCounter;
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
            if(mix.isMagenta == true)
            {
                req1perfect.SetActive(true);
                goldCounter = goldCounter + 200;
                mix.enabled = false;
            }
            else
            {
                mix.enabled = false;
                req1imperfect.SetActive(true);
                goldCounter = goldCounter + 50;

            }
        }

        else if (requestCounter == 2)
        {
            if (mix.isCyan == true)
            {
                mix.enabled = false;
                req2perfect.SetActive(true);
                goldCounter = goldCounter + 200;
            }
            else
            {
                mix.enabled = false;
                req2imperfect.SetActive(true);
                goldCounter = goldCounter + 50;
            }
        }
    }
	
}
