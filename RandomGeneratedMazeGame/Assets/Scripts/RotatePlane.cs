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
    void Update()
    {

        Vector3 lookDir = new Vector3(Camera.main.transform.forward.x,
                0, Camera.main.transform.forward.z);
        lookDir.Normalize();

        Vector3 baseDir = new Vector3(1, 0, 0);
        float dot = Vector3.Dot(lookDir, baseDir);

        float angle = dot * -20;
        meshFilter.transform.parent.rotation = Quaternion.Euler(-90, 0, 180);

        float deltaX = Camera.main.transform.parent.position.x - meshFilter.transform.parent.position.x;
        meshFilter.transform.parent.Rotate(0, 0, angle, Space.World);
        float newY = deltaX * Mathf.Sin(-angle*Mathf.Deg2Rad);
        Vector3 currentPos = meshFilter.transform.parent.position;
        currentPos.y = newY;
        meshFilter.transform.parent.position = currentPos;

    }
}
