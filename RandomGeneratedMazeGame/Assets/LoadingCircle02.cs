using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LoadingCircle02 : MonoBehaviour
{
    public bool startAnim = false;
    public Transform RadialProgress;
    public float myTime = 0f;

    //public GameObject gameObject; 

    //private followPath02 pScript;

    

    // Use this for initialization
    void Start()
    {

        RadialProgress.GetComponent<Image>().fillAmount = myTime;
        //GetComponent<followPath02>().enabled = false;

        //followPath02 pScript = gameObject.GetComponent<followPath02>();
    }

    // Update is called once per frame
    void Update()
    {

        myTime += Time.deltaTime;

        if (myTime > 3f)
        {
            startAnim = true;

        }

        RadialProgress.GetComponent<Image>().fillAmount = myTime / 3;
        

        if (myTime > 3f)
        {
            startAnim = true;

        }
        
    }

     

    public void resetTime()
    {
        myTime = 0f;
        RadialProgress.GetComponent<Image>().fillAmount = myTime;

        
    }

}
