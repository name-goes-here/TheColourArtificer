using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintScroll : MonoBehaviour {

    public Text hintText;
    public ScoreGold1 score;

	// Use this for initialization
	void Start () {

        hintText.GetComponent<Text>();
        score.GetComponent<ScoreGold1>();

        hintText.text = "";
	}
	
	// Update is called once per frame
	void Update () {

		if (score.requestCounter == 0)
        {
            hintText.text = "Jones is asking for a simple cyan. It should be crafted by mixing blue and green together. Simple enough.";
        }

        else if (score.requestCounter == 1)
        {
            hintText.text = "Now he wants his favourite colour, cerulean. A bit more complicated, but I can always consult the guidebook.";
        }

        else if (score.requestCounter == 2)
        {
            hintText.text = "She wishes for yellow. I wonder if they will look good for her roses.";
        }

        else if (score.requestCounter == 3)
        {
            hintText.text = "Lila wants purple. I better make this quick so she can sell her flowers sooner.";
        }

        else if (score.requestCounter == 4)
        {
            hintText.text = "The nerve! I need to make a colour for royalty or fitting for her if I want this arrogant woman out of my shop!";
        }

        else if (score.requestCounter == 5)
        {
            hintText.text = "A type of colour that is nearing a yellow shade. He also said that it starts with a 'P.' I wonder what it is.";
        }

        else if (score.requestCounter == 6)
        {
            hintText.text = "Sight of a sun and something about feeling warm? What is Gregorio blabbering on about?";
        }

        else if (score.requestCounter == 7)
        {
            hintText.text = "Sight of a sun and something about feeling warm? What is Gregorio blabbering on about?";
        }
    }

}
