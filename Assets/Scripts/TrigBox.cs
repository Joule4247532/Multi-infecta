using UnityEngine;

public class TrigBox : MonoBehaviour
{
    public GameObject player;
    void OnTriggerEnter(Collider collider)
    {
        if (collider.transform.parent != null)
        {
            if (collider.transform.parent.name == "Walls")
            {
                player.GetComponent<PlayerMouvement>().col = true;

            }
        }
    }
    void OnTriggerExit(Collider collider)
    {
        if (collider.transform.parent != null)
        {
            if (collider.transform.parent.name == "Walls")
            {
                player.GetComponent<PlayerMouvement>().col = false;
            }
        }
    }

}
