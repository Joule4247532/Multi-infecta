using System;
using UnityEngine;
using UnityEngine.UI;


public class Infected : MonoBehaviour
{
    public float LVinfect = 0f;
    public int cures = 0;
    public int maxCures = 5;
    public Slider slider;
    public Text text;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Patients")
        {
            if (cures <= 0)
            {
                LVinfect += 10f;
                SetInfectLV(LVinfect);
                collision.collider.GetComponent<PartnerMove>().die();
            }
            else
            {
                cures--;
                SetCureNum(cures);
                collision.collider.GetComponent<PartnerMove>().live();
            }
        }
    }
    

    public void SetInfectLV(float lv)
    {
        lv = Mathf.Clamp(lv, 0f, 100f);
        slider.value = lv;
    }
    public void SetCureNum(int c)
    {
        //text.text = c + "x";
    }

    public void GetCure()
    {
        if (cures < maxCures)
        {
            cures+=3;
            SetCureNum(cures);
        }
    }

    private void Start()
    {
        SetInfectLV(0f);
        SetCureNum(0);
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
