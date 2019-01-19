using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LoadingCircle02 : MonoBehaviour
{
    public bool test = false;
    public Transform RadialProgress;
    public float myTime = 0f;

    public GameObject gameObject;


    // Use this for initialization
    void Start()
    {

        RadialProgress.GetComponent<Image>().fillAmount = myTime;
        GetComponent<followPath02>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        myTime += Time.deltaTime;
        

        RadialProgress.GetComponent<Image>().fillAmount = myTime / 3;
        

        if (myTime > 3)
        {
            gameObject.GetComponent<followPath02>().enabled = true;
            setVar();
            Debug.Log("Test");
        }
        
    }

     void setVar()
    {
        gameObject.GetComponent<followPath02>().enabled = true;
        Debug.Log("Test");
    }


    public void resetTime()
    {
        myTime = 0f;
        RadialProgress.GetComponent<Image>().fillAmount = myTime;

        
    }

}
