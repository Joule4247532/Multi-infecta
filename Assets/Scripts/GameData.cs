using UnityEngine;

public class GameData : MonoBehaviour
{
    public GameObject data;
    private int cured;

    public void StoreData()
    {
        data.GetComponent<StaticData>().gameTime = Time.time - Time.timeSinceLevelLoad;
        data.GetComponent<StaticData>().cured = cured;
        data.GetComponent<StaticData>().storeData();
    }
    public void CountCured()
    {
        cured++;
    }
}
