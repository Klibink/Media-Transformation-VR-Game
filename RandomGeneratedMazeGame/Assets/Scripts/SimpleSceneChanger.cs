using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SimpleSceneChanger : MonoBehaviour {

    public int nextScene;

	// Use this for initialization
	void Start () {

        SceneManager.LoadScene(nextScene);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
