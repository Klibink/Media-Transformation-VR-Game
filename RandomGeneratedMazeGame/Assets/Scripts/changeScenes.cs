using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScenes : MonoBehaviour {

    public float myTime = 0f;
    public int nextScene;

    public ChangeScene cs;

	// Use this for initialization
	void Start () {
        cs = new ChangeScene();
    }
	
	// Update is called once per frame
	public void Update () {
		
        myTime += Time.deltaTime;

        if (myTime >= 3f)
        {
            //changeSz(nextScene);

            cs.wechsleSzene(nextScene);
        }

	}

    public void resetTimer()
    {
        myTime = 0f;
    }

    public void changeSz(int current)
    {
        //SceneManager.LoadScene(scenes[current]);
    }
}

