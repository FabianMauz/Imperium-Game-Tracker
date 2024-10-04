using System;
using Domain;
using TMPro;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    private string pointsFromPlayer = "0";
    private string pointsFromAutoma = "0";

    private Difficulty difficulty;

    [SerializeField]
    private TextMeshProUGUI inputPlayer;

    public void saveGameResult()
    {
        print("save game:" + inputPlayer.text);
    }

    public void setDifficulty(string difficulty)
    {
        this.difficulty = (Difficulty)Enum.Parse(typeof(Difficulty), difficulty);
        updateUI();
    }

    private void updateUI(){
print("new difficulty: "+difficulty);
    }
}
