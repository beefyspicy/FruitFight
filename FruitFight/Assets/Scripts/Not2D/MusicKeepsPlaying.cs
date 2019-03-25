using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicKeepsPlaying : MonoBehaviour {

	void Update ()
    {
        DontDestroyOnLoad(gameObject);

        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (sceneName == "InteractiveMenu")
        {
            Destroy(gameObject);
        }
    }
}
