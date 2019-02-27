using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnSchlafsack : MonoBehaviour {

    public Renderer rend;

    public GameObject particleHolder;
    public GameObject schlafsack;

    // Use this for initialization
    void Start () {
        Renderer rend = gameObject.GetComponent<Renderer>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    public void ToggleVisibility()
    {
        

            if (rend.enabled)
            {
                rend.enabled = false;
            }
            else
            {
                rend.enabled = true;
            }

        
    }

    public void DestroyObject()
    {


        particleHolder.SetActive(false);
    }

    public void ActivateSchlafsack()
    {
        schlafsack.SetActive(true);
    }
}
