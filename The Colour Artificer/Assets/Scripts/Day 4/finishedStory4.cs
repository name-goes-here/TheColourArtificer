﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finishedStory4 : MonoBehaviour {

    public ScoreGold4 finalGold;

    public GameObject finishFlag;

    public GameObject goodEnd, badEnd;


	// Use this for initialization
	void Start () {

        finalGold.GetComponent<ScoreGold>();

        finishFlag.GetComponent<GameObject>();

        goodEnd.GetComponent<GameObject>();
        badEnd.GetComponent<GameObject>();
    }
	
	// Update is called once per frame
	void Update () {
		
        if(finishFlag.activeSelf == false)
        {
            if(finalGold.goldCounter >= 1100)
            {
                goodEnd.SetActive(true);
            }
            else
            {
                badEnd.SetActive(true);
            }
        }

	}
}
