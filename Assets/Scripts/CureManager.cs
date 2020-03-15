using System;
using UnityEngine;

public class CureManager : MonoBehaviour
{
    public GameObject cure;
    private Transform[] spawns;
    public Vector2 spawnDelayMinMax = new Vector2(2f,5f);
    private float timer = 0f;
    private Transform nextSpawn;
    private bool exit = false;
    private float checkTimer = 0f;


    private void Start()
    {
        spawns = this.GetComponentsInChildren<Transform>();
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            timer = UnityEngine.Random.Range(spawnDelayMinMax.x, spawnDelayMinMax.y);
            do
            {
                nextSpawn = spawns[UnityEngine.Random.Range(0, spawns.Length)];
                if (isCure())
                {
                    SpawnCure(nextSpawn);
                    exit = true;
                }

            } while (!exit);
            exit = false;
        }
    }

    private bool isCure()
    {
        checkTimer -= Time.deltaTime;
        if (checkTimer <= 0f)
        {
            checkTimer = 1f;
            return true;
        }
        return false;
    }

    private void SpawnCure(Transform pos)
    {
        Instantiate(cure, pos.position, cure.transform.rotation);
    }
}
