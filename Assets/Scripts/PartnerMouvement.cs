using UnityEngine;

public class PartnerMouvement : MonoBehaviour
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

        rb.position = new Vector3(rb.position.x,0.75f,rb.position.z);
    }

}
