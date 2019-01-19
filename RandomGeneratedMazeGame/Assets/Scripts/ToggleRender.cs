using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleRender : MonoBehaviour {

    public float myTime = 0f;

    public void Update()
    {
        myTime += Time.deltaTime;

        if(myTime > 3f)
        {
            ToggleVisibility();
            myTime = 0f;
        }

    }

    public void ToggleVisibility()
    {
        foreach(Transform child in transform)
        { 

        Renderer rend = child.gameObject.GetComponent<Renderer>();

        if (rend.enabled)
        {
            rend.enabled = false;
        }
        else
        {
            rend.enabled = true;
        }

        }
    }

    public void resetTime()
    {
        myTime = 0f;
        
    }
}
