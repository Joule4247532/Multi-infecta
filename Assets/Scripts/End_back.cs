﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End_back : MonoBehaviour
{
    string Testing = "Testing";
    // Start is called before the first frame update
    void Start()
    {

    }

    public void Back()
    {
        GameObject.FindGameObjectWithTag("audiomanager").GetComponent<AudioManager>().Play("btnhover");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }

    // Update is called once per frame
    public void Exit()
    {
        GameObject.FindGameObjectWithTag("audiomanager").GetComponent<AudioManager>().Play("btnhover");
        Application.Quit();
    }

}


