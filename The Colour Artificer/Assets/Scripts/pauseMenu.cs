using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseMenu : MonoBehaviour {

    public static bool gamePaused = false;
    public GameObject pauseMenuUI;

	void Start () {
		
	}
	
	void Update () {
        //Press esc or p to pause
        if (Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape)) {
            if (gamePaused) {
                resume();
            } else {
                pause();
            }
        }
	}

    //Press pause button to pause
    public void pauseButton() {
        if (gamePaused) {
            resume();
        } else {
            pause();
        }
    }

    void pause() {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gamePaused = true;
    }

    public void resume() {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gamePaused = false;
    }

    public void quit() {
        print("quit");
        Application.Quit();
    }
}
