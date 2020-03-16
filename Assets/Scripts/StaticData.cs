using UnityEngine;

public class StaticData : MonoBehaviour
{
    static int curedStatic = 0;
    static float gameTimeStatic = 0f;
    public int score = 0;
    public int cured = 0;
    public float gameTime = 0f;

    private void Awake()
    {
        cured = curedStatic;
        gameTime = gameTimeStatic;
        score = (curedStatic * 20) - (int)(gameTimeStatic);
    }

    public void storeData()
    {
        curedStatic = cured;
        gameTimeStatic = gameTime;
    }
}
