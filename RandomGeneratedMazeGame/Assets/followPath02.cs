using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPath02 : MonoBehaviour
{
    public Transform[] target;
    public float speed;

    private int current;

    public LoadingCircle02 lc;


    public void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(lc.startAnim);
        if (lc.startAnim==true)
        {
        
        if (transform.position != target[current].position)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);

        }
        else
        {
                //current = (current + 1) % target.Length;
                GetComponent<followPath02>().enabled = false;
        }

        }
    }

   

    public void resetTime()
    {
       // myTime = 0f;
    }
}
