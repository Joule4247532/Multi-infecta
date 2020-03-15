using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class About_back : MonoBehaviour
{
    string Menu = "Menu";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Back()
    {
        SceneManager.LoadScene(Menu);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
