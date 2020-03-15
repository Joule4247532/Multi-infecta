using UnityEngine;

public class Seringue : MonoBehaviour
{
    public float animSpeed = 0.2f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<Infected>().GetCure();
            DeleteSelf();
        }
    }

    void DeleteSelf()
    {
        Destroy(GameObject.Find(this.name));
    }

    private void FixedUpdate()
    {
        this.transform.Rotate(new Vector3(0f,animSpeed,0f));
    }
}
