using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCanvas : MonoBehaviour {

    public GameObject gO;
    public RectTransform rectTransform;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (gO.name == "Canvas07")
        {
            if (rectTransform.position.x < -5)
                rectTransform.Translate(-Vector3.right * 2 * Time.deltaTime);
        }

        if (gO.name == "Canvas08")
        {
            if(rectTransform.position.x<5)
            rectTransform.Translate(Vector3.right * 2 * Time.deltaTime);
            
        }
		
	}
}
