using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangingtwo : MonoBehaviour {
    public Transform Stufen;
    public Material stufe1;
    public Material stufe2;
    // Use this for initialization
    void Start () {
        GetComponent<Renderer>().material = stufe1;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ChangeColor()
    {
        GetComponent<Renderer>().material = stufe2;
    }

    public void KeepColor()
    {
        GetComponent<Renderer>().material = stufe1;
    }
}
