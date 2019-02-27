using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingCircle : MonoBehaviour {

    public Transform RadialProgress;
    public float myTime = 0f;

	// Use this for initialization
	void Start () {

        RadialProgress.GetComponent<Image>().fillAmount = myTime;
	}
	
	// Update is called once per frame
	void Update () {

        myTime += Time.deltaTime;

        RadialProgress.GetComponent<Image>().fillAmount = myTime/3;
    }

    public void resetTime()
    {
        myTime = 0f;
        RadialProgress.GetComponent<Image>().fillAmount = myTime;
    }

}
