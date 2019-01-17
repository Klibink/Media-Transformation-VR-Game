using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CubeInteraction : MonoBehaviour {
    public float gazeTime = 2f;
    private float timer;
   private bool gazedAt;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
       if (gazedAt)
       {
           timer += Time.deltaTime;

            //   Transform child = transform.GetChild(0);
            //   Vector3 newScale = new Vector3(timer/2, child.localScale.y, child.localScale.z);
            // child.localScale = newScale;
        }

            if (timer >= gazeTime)
            {
                ExecuteEvents.Execute(gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerDownHandler);
                timer = 0f;

            }

        }
   
     public void PointerDown()
    {
        Debug.Log("PointerDown");

        
    }


	 } 

    



