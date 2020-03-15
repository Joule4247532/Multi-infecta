using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu_play : MonoBehaviour
{
    public GameObject Menu2;
    public string Testing;
    private void Start()
    {
        Menu2 = GameObject.Find("Menu_play2");
        Menu2.GetComponent<Renderer>().enabled = false;
    }

    public void OnMouseDown()
    {
        SceneManager.LoadScene(Testing);
    }
    void OnMouseOver()
    {
        //gameObject.SetActive(false);
        gameObject.GetComponent<Renderer>().enabled = false;
        Menu2.GetComponent<Renderer>().enabled = true;
    }

    void OnMouseExit()
    {
        gameObject.GetComponent<Renderer>().enabled = true;
        Menu2.GetComponent<Renderer>().enabled = false;
    }
}
