using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Phasen : MonoBehaviour {

    public Animator transitionAnim;

    public float myTime = 0f;
    public float myTime2 = 0f;
    public float myTime3 = 0f;
    public float myTime4 = 0f;
    int phase = 0;
    public followPath03 pathScriptObject;
    public moveWalls02 moveWallsScriptObject,moveLinkeWand,moveRechteWand;
    public GameObject c1, c2, c3, c4, c5, c6, c7,c8;

    public GameObject canvas;

    public int nextScene;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        switch (phase)
        {
            case 0:
                if (pathScriptObject.counter >= 1)
                {
                    c1.SetActive(true);
                }

                if (pathScriptObject.counter >= 3)
                {
                    c1.SetActive(false);
                    c2.SetActive(true);
                }

                break;

            case 1:
                myTime += Time.deltaTime;
                moveWallsScriptObject.startMovingRoof = true;
                c2.SetActive(false);
                c3.SetActive(true);

                if (myTime > 5)
                {
                    IncreaseInt();
                }

                break;

            case 2:
                myTime2 += Time.deltaTime;
                c3.SetActive(false);
                c4.SetActive(true);
                if (myTime2 > 3)
                {
                    IncreaseInt();
                }

                break;

            case 3:
                myTime3 += Time.deltaTime;
                c4.SetActive(false);
                c5.SetActive(true);
                moveWallsScriptObject.SetBool();
                
                IncreaseInt();
                
                break;

            case 4:
                myTime3 += Time.deltaTime;
                if (myTime3 > 5)
                {
                    c5.SetActive(false);
                    c6.SetActive(true);

                }
                if (myTime3 > 12)
                {
                    IncreaseInt();
                }

                break;


            case 5:
                myTime4 += Time.deltaTime;
                c6.SetActive(false);
                moveLinkeWand.MoveWalls = true;
                moveRechteWand.MoveWalls = true;
                c7.SetActive(true);
                c8.SetActive(true);

                if (myTime4 > 10)
                {
                    //SceneManager.LoadScene(nextScene);
                    StartCoroutine(changeSz());
                }


                break;
        }
        

    }

    public void ActivateCanvas()
    {
        if (canvas.activeInHierarchy)
        {
            canvas.SetActive(false);
            
        }
        else
        {
            canvas.SetActive(true);
            
        }
    }

    public void IncreaseInt()
    {
        phase++;
    }

    IEnumerator changeSz()
    {
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(nextScene);
    }
}
