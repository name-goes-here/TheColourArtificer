using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextDay : MonoBehaviour {

    //Set count to index of scene for Day 0 minus 1; EX: Day 0 is scene number 2, count = 1
    static int count = -1;

    void Start() {
        count++;
        StartCoroutine(loadNext());
    }

    IEnumerator loadNext() {
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene(count);
    }
}
