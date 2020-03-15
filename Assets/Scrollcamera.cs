using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrollcamera : MonoBehaviour
{
    public float Y = 0; // set this to 0.2
    public float B = 0; // set this to -0.2
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            transform.Translate(0, Y, -1);
        }
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            transform.Translate(0, B, 1);
        }
    }
}
