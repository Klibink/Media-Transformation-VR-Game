using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class deactivateVr : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(DeactivatorVR("none"));
	}

    public IEnumerator DeactivatorVR(string NoVr)
    {
        XRSettings.LoadDeviceByName(NoVr);
        yield return null;
        XRSettings.enabled = false;
    }
}
