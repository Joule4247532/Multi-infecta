using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{

    public enum SpawnState { SPAWNING, WAITING, COUNTING };

    [System.Serializable]
    public class Wave
    {
        public string name;
        public Transform enemy;
        public int count;
        public float rate;
    }

    public Wave[] waves;
    private int nextWave = 0;

    public float waveTimer = 5f;
    public float waveCountdown;

    public SpawnState state = SpawnState.COUNTING;

    void Start()
    {
        waveCountdown = waveTimer;
    }

    void Update()
    {
        if (waveCountdown <= 0)
        {

        }
    }
}
