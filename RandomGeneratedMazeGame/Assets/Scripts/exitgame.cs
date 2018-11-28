using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitgame : MonoBehaviour {

    public void ClickExit()
    {
        Application.Quit();
        Debug.Log("Spiel beendet");
    }
}
