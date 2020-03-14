using UnityEngine;

public class TrigBox : MonoBehaviour
{
    public GameObject player;
    void OnTriggerEnter(Collider collider)
    {
        if (collider.name != "Player" || collider.name != "Partner")
        {
            player.GetComponent<PlayerMouvement>().col = true;
            
        }
    }
    void OnTriggerExit(Collider collider)
    {
        if (collider.name != "Player" || collider.name != "Partner")
        {
            player.GetComponent<PlayerMouvement>().col = false;
        }
    }

}
