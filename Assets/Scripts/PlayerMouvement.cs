using UnityEngine;

public class PlayerMouvement : MonoBehaviour
{

    public Rigidbody rb;
    public float speed = 20f;
    private float trueSpeed;
    public bool col = false;


    // Update is called once per frame
    void FixedUpdate()
    {
        if (col)
        {
            trueSpeed = speed / 7f;
        }
        else
        {
            trueSpeed = speed;
        }

        if (Input.GetKey("a") && !Input.GetKey("d"))
        {
            rb.position += new Vector3(-trueSpeed / 1000, 0, 0);
        }
        if (Input.GetKey("d") && !Input.GetKey("a"))
        {
            rb.position += new Vector3(trueSpeed / 1000, 0, 0);
        }
        if (Input.GetKey("w") && !Input.GetKey("s"))
        {
            rb.position += new Vector3(0, 0, trueSpeed / 1000);
        }
        if (Input.GetKey("s") && !Input.GetKey("w"))
        {
            rb.position += new Vector3(0, 0, -trueSpeed / 1000);
        }

        rb.position = new Vector3(rb.position.x,0.75f,rb.position.z);
    }

}
