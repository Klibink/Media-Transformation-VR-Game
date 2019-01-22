using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class followPath : MonoBehaviour {

    public Transform[] target;
    public float speed;

    private int current;

    public int nextScene;
    
    // Update is called once per frame
    void Update () {

        Vector3 lookDir = new Vector3(Camera.main.transform.forward.x,
                0, Camera.main.transform.forward.z);
        lookDir.Normalize();

        Vector3 baseDir = new Vector3(1, 0, 0);
        float dot = Vector3.Dot(lookDir, baseDir);

        if (dot < 0)
        {
            current = 0;
        }

        else
        {
            current = 1;
        }

        if (transform.position != target[current].position)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);

        }
        else
        {
            //current = (current + 1) % target.Length;
            SceneManager.LoadScene(nextScene);
        }
	}
}
