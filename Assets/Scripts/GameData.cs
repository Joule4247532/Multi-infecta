using UnityEngine;

public class GameData : MonoBehaviour
{
    public GameObject data;
    private int cured;
    private float timeStart;

    private void Awake()
    {
        timeStart = Time.time;
    }

    public void StoreData()
    {
        data.GetComponent<StaticData>().gameTime = Time.time - timeStart;
        data.GetComponent<StaticData>().cured = cured;
        data.GetComponent<StaticData>().storeData();
    }
    public void CountCured()
    {
        cured++;
    }
}
