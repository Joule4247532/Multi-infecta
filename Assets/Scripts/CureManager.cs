using System;
using UnityEngine;

public class CureManager : MonoBehaviour
{
    public GameObject cure;
    private Transform[] spawns;
    public Vector2 spawnDelayMinMax = new Vector2(2f,5f);
    private float timer = 0f;


    private void Start()
    {
        spawns = this.GetComponentsInChildren<Transform>();
    }

    private void Update()
    {
        if (timer <= 0f)
        {
            timer = UnityEngine.Random.Range(spawnDelayMinMax.x, spawnDelayMinMax.y);
            SpawnCure(spawns[UnityEngine.Random.Range(0,spawns.Length)]);
        }
        timer -= Time.deltaTime;
    }

    private void SpawnCure(Transform pos)
    {
        Instantiate(cure, pos.position, cure.transform.rotation);
    }
}
