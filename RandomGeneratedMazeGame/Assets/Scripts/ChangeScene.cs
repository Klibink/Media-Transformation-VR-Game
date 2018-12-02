﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene 
{

    public string[] scenes = { "Startmenu", "Szene01", "Sandbox" };
    //public int current;



    private void Start()
    {
        SceneManager.LoadScene("Sandbox");
    }
    
    public void wechsleSzene(int current)
    {
        SceneManager.LoadScene(scenes[current]);
    }
}
