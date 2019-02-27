using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMovingScript : MonoBehaviour {

    public float myTime = 0f;
    public GameObject startPoint;
    public GameObject textMesh;

    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        myTime += Time.deltaTime;

        if (myTime >= 3)
        {
            GetComponent<controller>().enabled = true;
            GetComponent<CapsuleCollider>().enabled = true;
            transform.position = startPoint.transform.position;

            textMesh.GetComponent<Canvas>().enabled = false;
        }
    }


    public void startMoving()
    {
        

        



    }

    public void resetTimer()
    {
        myTime = 0f;
    }

}
