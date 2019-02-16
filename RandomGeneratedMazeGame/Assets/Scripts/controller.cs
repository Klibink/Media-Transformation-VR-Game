using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class controller : MonoBehaviour {

    public float speed;
    public int nextScene;
    
    private bool walking = true;
    private Vector3 spawnPoint;
    private AudioSource footsteps;
    private bool playing = false;

    private bool wasHittingLastFrame = false;
    
	// Use this for initialization
	void Start () {

        spawnPoint = transform.position;
        footsteps = GetComponent<AudioSource>();
        footsteps.Play(0);
        playing = true;
		
	}
	
	// Update is called once per frame
	void Update () {

        if (walking)
        {
            Vector3 lookDir = new Vector3(Camera.main.transform.forward.x,
                0,Camera.main.transform.forward.z);
            lookDir.Normalize();
            transform.position = transform.position + lookDir * speed * Time.deltaTime;
        }

        if(walking&& !playing)
        {
            footsteps.UnPause();
            playing = true;
        }
        else if(!walking && playing)
        {
            footsteps.Pause();
            playing = false;
        }
        if(transform.position.y < -5f)
        {
            //transform.position = spawnPoint;
            //SceneManager.LoadScene(nextScene);
            GetComponent<SceneTransitions>().enabled = true;
        }


        float fYRot = Camera.main.transform.forward.y;
        if (fYRot < -0.4f)
        {
            if (!wasHittingLastFrame)
            {
                walking = !walking;
            }
            wasHittingLastFrame = true;
        } else
        {
            wasHittingLastFrame = false;
        }
	}
}
