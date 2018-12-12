using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Vr2dChanger : MonoBehaviour {

	// Use this for initialization
	public void Start () {
        StartCoroutine(ActivatorVR("cardboard"));
	}
	
    public IEnumerator ActivatorVR(string activateVR)
    {
        XRSettings.LoadDeviceByName(activateVR);
        yield return null;
        XRSettings.enabled = true;
    }

	
}

