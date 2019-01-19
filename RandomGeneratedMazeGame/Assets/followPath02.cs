using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPath02 : MonoBehaviour
{
    public float myTime = 0f;
    public float myTime2 = 0f;

    private bool startTrans=false;

    public Transform[] target;
    public float speed;

    private int current;


    public void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        myTime += Time.deltaTime;

        

        

        if (transform.position != target[current].position)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);

        }
        else
        {
            current = (current + 1) % target.Length;
        }

        
    }

   

    public void resetTime()
    {
        myTime = 0f;
    }
}
