using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintScroll4 : MonoBehaviour {

    public Text hintText;
    public ScoreGold4 score;

	// Use this for initialization
	void Start () {

        hintText.GetComponent<Text>();
        score.GetComponent<ScoreGold4>();

        hintText.text = "";
	}
	
	// Update is called once per frame
	void Update () {

		if (score.requestCounter == 0)
        {
            hintText.text = "Lila wants another lavender? It must be a popular flower for her and her clients.";
        }

        else if (score.requestCounter == 1)
        {
            hintText.text = "So Lila wants a colour that is mixed with the base of loyalty. A colour not too dark or light. Let us see what we can make.";
        }

        else if (score.requestCounter == 2)
        {
            hintText.text = "Madame Plundell is asking for her usual colour that fits her best. I should not disappoint then.";
        }

        else if (score.requestCounter == 3)
        {
            hintText.text = "Madame Plundell suggests I give Charles the colour that depicted itself as a reinvigorating colour. What was it again?";
        }

        else if (score.requestCounter == 4)
        {
            hintText.text = "The council members entrusted me to find the perfect colour for both of them, a bountiful and live-filled colour.";
        }

        else if (score.requestCounter == 5)
        {
            hintText.text = "Seems like Oran has found his calling. Now I should help him in giving him a bright and exciting colour!";
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
