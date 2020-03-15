using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{

    public enum SpawnState { SPAWNING, WAITING, COUNTING };

    [System.Serializable]
    public class Wave
    {
        public int count;
        public float rate;
    }

    public Wave[] waves;
    private int nextWave = 0;

    public Transform[] spawnPoints;
    public GameObject[] patients;

    public float waveTimer = 5f;
    private float waveCountdown;

    private float searchTimer = 1f;

    private SpawnState state = SpawnState.COUNTING;

    void Start()
    {
        waveCountdown = waveTimer;
    }

    void Update()
    {
        if (state == SpawnState.WAITING)
        {
            if (!EnemyIsAlive())
            {
                NextWave();
            }
            else
            {
                return;
            }
        }
        
        if (waveCountdown <= 0)
        {
            if (state != SpawnState.SPAWNING)
            {
                StartCoroutine(SpawnWave(waves[nextWave]));
            }
        }
        else
        {
            waveCountdown -= Time.deltaTime;
        }
    }

    void NextWave()
    {

        state = SpawnState.COUNTING;
        waveCountdown = waveTimer;

        if (nextWave + 1 > waves.Length - 1)
        {
            nextWave = 0;
            //End of waves
        }
        else
        {
            nextWave++;
        }
    }

    bool EnemyIsAlive()
    {
        searchTimer -= Time.deltaTime;
        if (searchTimer <= 0f)
        {
            searchTimer = 1f;

            if (true)// GameObject.FindGameObjectsWithTag("Patients").Length == 0)
            {
                return false;
            }
        }
        return true;
    }

    IEnumerator SpawnWave(Wave _wave)
    {
        state = SpawnState.SPAWNING;

        for (int i = 0; i < _wave.count; i++)
        {
            SpawnPatient(patients[Random.Range(0, patients.Length)].transform);
            yield return new WaitForSeconds(1f / _wave.rate);
        }

        state = SpawnState.WAITING;

        yield break;
    }

    void SpawnPatient(Transform _patient)
    {
        if (spawnPoints.Length == 0)
        {
            Debug.LogError("No Spawn Points");
            return;
        }
        Transform _sp = spawnPoints[ Random.Range(0,spawnPoints.Length)];
        Instantiate(_patient, _sp.position, _sp.rotation);
    }
}
