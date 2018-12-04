using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlane : MonoBehaviour {

    private MeshFilter meshFilter;

	// Use this for initialization
	void Start () {

        meshFilter = GetComponent<MeshFilter>();
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 lookDir = new Vector3(Camera.main.transform.forward.x,
                0, Camera.main.transform.forward.z);
        lookDir.Normalize();

        Vector3 baseDir = new Vector3(1, 0, 0);
        float dot = Vector3.Dot(lookDir, baseDir);

        float angle = dot * -20;
        meshFilter.transform.rotation = Quaternion.Euler(0, 0, angle);

        float deltaX = Camera.main.transform.position.x - meshFilter.transform.position.x;
        float move = Mathf.Sin(angle) * deltaX;

        Vector3 loc = meshFilter.transform.position;
        //meshFilter.transform.position = new Vector3(loc.x, loc.y+move, loc.z);
            }
}
