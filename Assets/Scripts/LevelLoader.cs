using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelLoader : MonoBehaviour
{
    public Animator transition;

    public float transitionTime = 1f;

    public int nextIndex = 2;
   
    public void OnMouseDown()
    {
        GameObject.FindGameObjectWithTag("audiomanager").GetComponent<AudioManager>().Play("btn");
        LoadNextLevel();
    }
    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + nextIndex));
    }
    public void LoadNextScene(int index)
    {
        if (index > SceneManager.sceneCountInBuildSettings || index < 0)
        {
            throw new Exception("Not a valid scene index");
        }
        StartCoroutine(LoadLevel(index));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(levelIndex);
    }
}


