using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_options : MonoBehaviour
{
    public GameObject Options2;
    private void Start()
    {
        Options2 = GameObject.Find("Menu_options2");
        Options2.GetComponent<Renderer>().enabled = false;
    }
    void OnMouseOver()
    {
        //gameObject.SetActive(false);
        gameObject.GetComponent<Renderer>().enabled = false;
        Options2.GetComponent<Renderer>().enabled = true;
    }


    void OnMouseExit()
    {
        gameObject.GetComponent<Renderer>().enabled = true;
        Options2.GetComponent<Renderer>().enabled = false;
    }
}