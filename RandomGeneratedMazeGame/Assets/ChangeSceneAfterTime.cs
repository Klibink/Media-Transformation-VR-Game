using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneAfterTime : MonoBehaviour {

    public float myTime;
    public int nextScene;

	// Use this for initialization
	void Start () {
        myTime = 0f;
	}
	
	// Update is called once per frame
	void Update () {
        myTime += Time.deltaTime;

        if (myTime > 10)
        {
            SceneManager.LoadScene(nextScene);
        }
	}
}
