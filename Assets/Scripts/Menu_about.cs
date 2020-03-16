using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_about : MonoBehaviour
{
    public GameObject About2;
    string About = "About";
    private void Start()
    {
        About2 = GameObject.Find("Menu_about2");
        About2.GetComponent<Renderer>().enabled = false;
    }

    /*public void OnMouseDown()
    {
        SceneManager.LoadScene(About);
    }*/
    void OnMouseOver()
    {
        sound();
        //gameObject.SetActive(false);
        gameObject.GetComponent<Renderer>().enabled = false;
        About2.GetComponent<Renderer>().enabled = true;
    }


    void OnMouseExit()
    {
        soundMade = false;
        gameObject.GetComponent<Renderer>().enabled = true;
        About2.GetComponent<Renderer>().enabled = false;
    }
    private bool soundMade = false;
    private void sound()
    {
        if (!soundMade)
        {
            GameObject.FindGameObjectWithTag("audiomanager").GetComponent<AudioManager>().Play("btnhover");
            soundMade = true;
        }
    }
}
