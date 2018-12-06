using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintScroll3 : MonoBehaviour {

    public Text hintText;
    public ScoreGold3 score;

	// Use this for initialization
	void Start () {

        hintText.GetComponent<Text>();
        score.GetComponent<ScoreGold3>();

        hintText.text = "";
	}
	
	// Update is called once per frame
	void Update () {

		if (score.requestCounter == 0)
        {
            hintText.text = "Jones wants me to make his favourite colour again. This should be easy.";
        }

        else if (score.requestCounter == 1)
        {
            hintText.text = "A colour for a cake, fitting for a lasting love for Byron and honesty and loyalty for Madeleine. What can be the best choice here?";
        }

        else if (score.requestCounter == 2)
        {
            hintText.text = "Oran is drastically suffering from wanting to become his own self. He cannot get any rest from his turmoil. What should I do?";
        }

        else if (score.requestCounter == 3)
        {
            hintText.text = "Madame Plundell seems to have a change of heart. She wishes for a classy and peaceful, yet a stimulating colour.";
        }

        else if (score.requestCounter == 4)
        {
            hintText.text = "Gregorio is under a trance, saying something about royalty. . . What does he mean by that?";
        }

        else if (score.requestCounter == 5)
        {
            hintText.text = "A colour that would complement a nice day at the spa or a ship, what is going on in that man's head?";
        }

        else if (score.requestCounter == 6)
        {
            hintText.text = "A colour that shares the same name of that of a flower? What could it be?";
        }

        else if (score.requestCounter == 7)
        {
            hintText.text = "A bellflower carries the colour of either purple or lavender? Either one should do.";
        }

        else if (score.requestCounter == 8)
        {
            hintText.text = "What was the colour that I've made for the dandelion? I should be able to remember!";
        }
    }

}
