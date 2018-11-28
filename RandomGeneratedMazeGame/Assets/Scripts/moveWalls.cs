using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveWalls : MonoBehaviour {

    private float startMoveWalls = 5f;
    private bool rotateds=false;
    private float time = 0f;
    private Mesh mesh;
    private float scaleY = 1f;
    private float scaleX = 1f;
    private bool direction = true;
    private Vector3[] originalVertices;

    private bool isFloor = false;
    private bool isRotated = false;

	// Use this for initialization
	void Start () {
        MeshFilter filter = GetComponent<MeshFilter>();
        isFloor = filter.transform.up.y < 0.7f;
        if (isFloor)
        {
            return;
        }
        isRotated = !(filter.transform.right.x < 0.7);

        mesh = GetComponent<MeshFilter>().mesh;

        originalVertices = new Vector3[mesh.vertices.Length];
        for (int i = 0; i < mesh.vertices.Length; i++)
        {
            originalVertices[i] = new Vector3();
            originalVertices[i].x = mesh.vertices[i].x;
            originalVertices[i].y = mesh.vertices[i].y;
            originalVertices[i].z = mesh.vertices[i].z;
        }

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (isFloor)
        {
            return;
        }
        time += Time.deltaTime;
        if(time>= startMoveWalls)
        {
            if (direction)
            {
                scaleY += Time.deltaTime * 0.3f;
                scaleX += Time.deltaTime * 0.9f;
                if (scaleY >= 2f)
                {
                    direction = false;
                    scaleY = 2f;
                    scaleX = 4f;
                }
            }
            else
            {
                scaleY -= Time.deltaTime * 0.3f;
                scaleX -= Time.deltaTime * 0.9f;
                if (scaleY <= 1f)
                {
                    rotateds = !rotateds;
                    direction = true;
                    scaleY = 1f;
                    scaleX = 1f;
                }
            }
            Vector3[] vertices = new Vector3[mesh.vertices.Length];
            for (int i = 0; i < mesh.vertices.Length; i++)
            {
                vertices[i] = new Vector3();

                vertices[i].x = originalVertices[i].x * 1;

                vertices[i].y = originalVertices[i].y * scaleY;
                if (vertices[i].y < -0.5f) vertices[i].y = -0.5f;
                

                if ((rotateds && isRotated) || (!rotateds && !isRotated))
                {
                    vertices[i].z = originalVertices[i].z * scaleX;
                }
                else
                {
                    vertices[i].z = originalVertices[i].z * 1;
                }
            }
            mesh.vertices = vertices;
            mesh.RecalculateBounds();
            //mesh.UploadMeshData(false);

        }
	}
}
