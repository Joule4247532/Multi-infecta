using System.Collections;
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
        SceneManager.LoadScene(Testing);

    }

    // Update is called once per frame
    void Update()
    {

    }

}


