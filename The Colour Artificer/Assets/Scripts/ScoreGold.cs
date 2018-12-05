using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreGold : MonoBehaviour {

    public int requestCounter;
    public int goldCounter;

    public GameObject req, req1p, req1n, req2p, req2n, req3p, req3n;

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

            mix.enabled = false;
            req1p.SetActive(true);
            goldCounter = goldCounter + 200;

        }

    
    }
	
}
