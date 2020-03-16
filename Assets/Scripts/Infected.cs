using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Infected : MonoBehaviour
{
    public GameObject data;
    public float LVinfect = 0f;
    public int cures = 0;
    public int maxCures = 5;
    public Slider slider;
    public Text text;
    public int cureVal;
    public float infectLV = 5f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Patients")
        {
            if (cures <= 0)
            {
                LVinfect += infectLV;
                SetInfectLV(LVinfect);
                collision.collider.GetComponent<PartnerMove>().die();
            }
            else
            {
                cures--;
                SetCureNum(cures);
                data.GetComponent<GameData>().CountCured();
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
        text.text = c + "x";
    }

    public void GetCure()
    {
        if (cures < maxCures)
        {
            cures+=cureVal;
            if (cures > maxCures)
            {
                cures = maxCures;
            }
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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!(cures <= 0 || LVinfect <= 0))
            {
                cures--;
                LVinfect -= 10f;
                if (LVinfect < 0f)
                {
                    LVinfect = 0f;
                }
                SetCureNum(cures);
                SetInfectLV(LVinfect);
            }

        }
    }

    private void weDie()
    {
        data.GetComponent<GameData>().StoreData();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
