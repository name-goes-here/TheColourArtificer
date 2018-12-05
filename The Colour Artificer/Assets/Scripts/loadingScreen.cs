using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadingScreen : MonoBehaviour {

    //AsyncOperation async;
    //int count = -1;

    public void loading() {
        SceneManager.LoadScene("Loading Screen");
    }

    /*  TESTING FOR ACTUAL LOADING SCREEN ASYNC PROCESS
    IEnumerator LoadingScreen() {
        //Switch to loading screen
        SceneManager.LoadScene("Loading Screen");
        async = SceneManager.LoadSceneAsync(2);
        async.allowSceneActivation = false;
        print(3);
        while (async.isDone == false) {
            print(4);
            //Is scene or level fully loaded
            if (async.progress == 0.9f) {
                print(5);
                yield return new WaitForSecondsRealtime(3);
                print("Waited");
                async.allowSceneActivation = true;
            }
            print(6);
            yield return null;
        }
    }*/
}
