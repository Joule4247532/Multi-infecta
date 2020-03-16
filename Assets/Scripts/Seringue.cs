using UnityEngine;

public class Seringue : MonoBehaviour
{
    public float animSpeed = 0.2f;
    public GameObject audioManager;


    private void Start()
    {
        audioManager = GameObject.FindGameObjectWithTag("audiomanager");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<Infected>().GetCure();
            DeleteSelf();
           audioManager.GetComponent<AudioManager>().Play("SFX");
        }
    }

    void DeleteSelf()
    {
        Destroy(this.gameObject);
    }

    private void FixedUpdate()
    {
        this.transform.Rotate(new Vector3(0f,animSpeed,0f));
    }
}
