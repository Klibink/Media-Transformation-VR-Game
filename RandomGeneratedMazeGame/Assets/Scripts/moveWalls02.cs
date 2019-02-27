using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveWalls02 : MonoBehaviour {

    public float moveSpeed=2f;

    public GameObject go;
    public bool startMovingRoof = false;
    public bool MoveRoof = true;
    public bool MoveWalls = false;

    



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        if (go.name == "Decke")
        {
            if (startMovingRoof)
            {
                if (MoveRoof)
                {
                    if (go.transform.position.y > 3)
                    {
                        transform.Translate(-Vector3.up * moveSpeed * Time.deltaTime);
                    }
                }

                else
                {
                    transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
                }

            }
        }

        if (go.name == "WandLinks")
        {
            if (MoveWalls)
            {
              transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            }
        }

        if (go.name == "WandRechts")
        {
            if (MoveWalls)
            {
              transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
            }
        }





    }

    public void SetBool()
    {
        MoveRoof = !MoveRoof;
    }

   



}
