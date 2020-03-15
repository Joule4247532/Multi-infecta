using System;
using UnityEngine;

public class Infected : MonoBehaviour
{
    public float LVinfect = 0f;
    public int cures = 0;
    public int maxCures = 5;
    public MonoBehaviour slider;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Patients")
        {
            if (cures <= 0)
            {
                LVinfect += 10f;

                collision.collider.GetComponent<PartnerMove>().die();
            }
            else
            {
                cures--;
                collision.collider.GetComponent<PartnerMove>().live();
            }
        }
    }

    public void GetCure()
    {
        if (cures < maxCures)
        {
            cures++;
        }
    }

    private void Update()
    {
        if (LVinfect >= 100f)
        {
            weDie();
        }
    }

    private void weDie()
    {
        throw new NotImplementedException();
    }
}
