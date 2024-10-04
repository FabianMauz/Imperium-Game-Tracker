using System;
using Domain;
using TMPro;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    private int pointsOfPlayer;
    private int pointsOfAutoma;

    private Difficulty difficulty;

    [SerializeField]
    private TextMeshProUGUI playerPoints;

    [SerializeField]
    private TextMeshProUGUI automaPoints;

    public void initPanel(string matchIdentificator)
    {
        print("Match " + matchIdentificator);
    }

    public void saveGameResult() { }

    public void setDifficulty(string difficulty)
    {
        this.difficulty = (Difficulty)Enum.Parse(typeof(Difficulty), difficulty);
        updateUI();
    }

    public void changePoints()
    {
        updateUI();
    }

    private void updateUI()
    {
        print("new difficulty: " + difficulty);
    }
}
