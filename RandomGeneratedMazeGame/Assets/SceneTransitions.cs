using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitions : MonoBehaviour {

    public float myTime = 0f;
    public Animator transitionAnim;
    public int nextScene;

    void Update()
    {
        myTime += Time.deltaTime;

        if (myTime >= 3f)
        {
            //changeSz(nextScene);

            //cs.wechsleSzene(nextScene);

            StartCoroutine(changeSz());
        }
    }


    IEnumerator changeSz()
    {
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(nextScene);
    }

}
