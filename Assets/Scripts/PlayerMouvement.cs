using UnityEngine;

public class PlayerMouvement : MonoBehaviour
{

    public Rigidbody rb;
    public Transform tr;
    public float speed = 20f;
    private float trueSpeed;
    public bool col = false;
    private float angle;

    private void Start()
    {
        angle = 0f;
    }

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
            angle = 270f;
        }
        if (Input.GetKey("d") && !Input.GetKey("a"))
        {
            rb.position += new Vector3(trueSpeed / 1000, 0, 0);
            angle = 90f;
        }
        if (Input.GetKey("w") && !Input.GetKey("s"))
        {
            rb.position += new Vector3(0, 0, trueSpeed / 1000);
            angle = 0f;
        }
        if (Input.GetKey("s") && !Input.GetKey("w"))
        {
            rb.position += new Vector3(0, 0, -trueSpeed / 1000);
            angle = 180f;
        }

        rb.position = new Vector3(rb.position.x,0.64f,rb.position.z);
        tr.rotation = Quaternion.Euler(-90f, angle, 0f);
        rb.velocity = new Vector3(0f, 0f, 0f);
    }

}
