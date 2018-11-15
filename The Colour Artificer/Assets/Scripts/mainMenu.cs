using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour {

	void Start () {
		
	}
	
	void Update () {
		
	}

    public void playGame() {
        SceneManager.LoadScene("test scene");
    }

    public void quitGame() {
        Application.Quit();
    }
}
