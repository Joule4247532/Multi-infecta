using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_about : MonoBehaviour
{
    public GameObject About2;
    private void Start()
    {
        About2 = GameObject.Find("Menu_about2");
        About2.GetComponent<Renderer>().enabled = false;
    }
    void OnMouseOver()
    {
        //gameObject.SetActive(false);
        gameObject.GetComponent<Renderer>().enabled = false;
        About2.GetComponent<Renderer>().enabled = true;
    }


    void OnMouseExit()
    {
        gameObject.GetComponent<Renderer>().enabled = true;
        About2.GetComponent<Renderer>().enabled = false;
    }
}
