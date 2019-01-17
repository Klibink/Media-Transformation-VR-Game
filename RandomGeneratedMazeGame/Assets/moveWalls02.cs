using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveWalls02 : MonoBehaviour {

    public float moveSpeed=2f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(-Vector3.right * moveSpeed * Time.deltaTime);

	}
}
