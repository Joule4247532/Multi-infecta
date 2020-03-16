using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverData : MonoBehaviour
{
    public Text scoreBoard;
    public Text patientBoard;
    public Text timeBoard;
    public GameObject data;

    void Start()
    {
        scoreBoard.text = "Score: " + data.GetComponent<StaticData>().score.ToString();
        patientBoard.text = "Cured patients: " + data.GetComponent<StaticData>().cured.ToString();
        timeBoard.text = "Time Played: " + data.GetComponent<StaticData>().gameTime.ToString();
    }
}
