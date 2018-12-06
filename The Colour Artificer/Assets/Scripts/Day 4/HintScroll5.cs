using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintScroll5 : MonoBehaviour {

    public Text hintText;
    public ScoreGold5 score;

	// Use this for initialization
	void Start () {

        hintText.GetComponent<Text>();
        score.GetComponent<ScoreGold5>();

        hintText.text = "";
	}
	
	// Update is called once per frame
	void Update () {

		if (score.requestCounter == 0)
        {
            hintText.text = "The couple wishes for my favourite colour? I wonder for what reason.";
        }

        else if (score.requestCounter == 1)
        {
            hintText.text = "Madame Plundell is quite ambitious: a colour for her greatest piece, to help leave her legacy as the most amazing painter!";
        }

        else if (score.requestCounter == 2)
        {
            hintText.text = "Oran has accepted who he is, to accept an 'unmanly' colour in spite of being in a line of stoic figures. Good for him.";
        }

        else if (score.requestCounter == 3)
        {
            hintText.text = "A riddle: an object that is always there and always returning. Some will see it rise and fall, but its always at its peak.";
        }

        else if (score.requestCounter == 4)
        {
            hintText.text = "Hmmm. Lila wants a colour I have never given her before. I must remember the colours I have given her and avoid those.";
        }

        else if (score.requestCounter == 5)
        {
            hintText.text = "This is it, my final colour! A colour that is seen as a friend to all.";
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
