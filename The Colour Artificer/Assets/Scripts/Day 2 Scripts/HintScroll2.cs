using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintScroll2 : MonoBehaviour {

    public Text hintText;
    public ScoreGold2 score;

	// Use this for initialization
	void Start () {

        hintText.GetComponent<Text>();
        score.GetComponent<ScoreGold2>();

        hintText.text = "";
	}
	
	// Update is called once per frame
	void Update () {

		if (score.requestCounter == 0)
        {
            hintText.text = "Lila is asking me to remember and give her the colour she told me yesterday. What was it that she said?";
        }

        else if (score.requestCounter == 1)
        {
            hintText.text = "Quite the description: a colour that transcends the bonds of friendship.";
        }

        else if (score.requestCounter == 2)
        {
            hintText.text = "This boy's sister needs a 'manly' colour for him, but he seems unsure. Perhaps he would like something different.";
        }

        else if (score.requestCounter == 3)
        {
            hintText.text = "Plundell wants a colour like before, but she may be in need of something else. Gregorio said that I should giver her an invigorating one.";
        }

        else if (score.requestCounter == 4)
        {
            hintText.text = "A colour to stimulate creativity, yet promotes quality and compassion. What colour will fit best for what Gregorio wants?";
        }

        else if (score.requestCounter == 5)
        {
            hintText.text = "Both council members want a different colour: red or blue. Which to choose? Or is there a way to find a colour fit for both?";
        }


    }

}
