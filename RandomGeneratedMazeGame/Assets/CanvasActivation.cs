using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasActivation : MonoBehaviour {

    public followPath03 fp;

    public GameObject c1, c2, c3, c4;

    public int nextScene;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        
        switch (fp.counter)
        {
            case 0:


                c1.SetActive(true);
                c2.SetActive(false);
                c3.SetActive(false);
                c4.SetActive(false);

                break;
            case 1:
                c1.SetActive(false);
                c2.SetActive(true);
                c3.SetActive(false);
                c4.SetActive(false);

                break;
            case 2:
                c1.SetActive(false);
                c2.SetActive(false);
                c3.SetActive(true);
                c4.SetActive(false);

                break;
            case 3:
                c1.SetActive(false);
                c2.SetActive(false);
                c3.SetActive(false);
                c4.SetActive(true);

                break;
            case 4:

                SceneManager.LoadScene(nextScene);

                break;
        }

    }

}
