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
        SceneManager.LoadScene("Day 1");
    }

    public void quitGame() {
        Application.Quit();
    }
}
