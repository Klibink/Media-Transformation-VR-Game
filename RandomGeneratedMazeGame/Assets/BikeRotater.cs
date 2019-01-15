using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeRotater : MonoBehaviour {
    

    // Update is called once per frame
    void Update()
    {

        Vector3 lookDir = new Vector3(Camera.main.transform.forward.x,
                0, Camera.main.transform.forward.z);
        lookDir.Normalize();

        Vector3 baseDir = new Vector3(1, 0, 0);
        float dot = Vector3.Dot(lookDir, baseDir);

        float angle = dot * -20;
        float absoluteDot = Mathf.Abs(dot);
        float temp = (1-(dot + 1) / 2) * 180;

        Vector3 rotationAngles = Camera.main.transform.rotation.ToEulerAngles();

        transform.localRotation = Quaternion.Euler(absoluteDot*-angle, 0, rotationAngles.y*Mathf.Rad2Deg-90);

    }
}
