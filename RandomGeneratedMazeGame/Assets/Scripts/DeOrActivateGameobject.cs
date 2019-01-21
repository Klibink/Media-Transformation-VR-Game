using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeOrActivateGameobject : MonoBehaviour {

    public GameObject gameObject;

    public void SetGameObject()
    {
        if (gameObject.activeInHierarchy==true)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }
    }
}
