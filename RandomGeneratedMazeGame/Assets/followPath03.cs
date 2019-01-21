using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPath03 : MonoBehaviour
{
    public Transform[] target;
    public float speed;

    private int current;
    public int counter;

    


    public void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
            if (transform.position != target[1].position)
            {
                Vector3 pos = Vector3.MoveTowards(transform.position, target[1].position, speed * Time.deltaTime);
                GetComponent<Rigidbody>().MovePosition(pos);

            }
            else
            {
            //current = (current + 1) % target.Length;
            transform.position = target[0].position;
            counter++;
            }

        
    }



    public void resetTime()
    {
        // myTime = 0f;
    }
}
