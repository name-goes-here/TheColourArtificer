using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class optionsMenu : MonoBehaviour {

    public AudioMixer mixer;

	void Start () {
		
	}
	
	void Update () {
		
	}

    public void setVolume(float volume) {
        mixer.SetFloat("volume", volume);
    }
}
