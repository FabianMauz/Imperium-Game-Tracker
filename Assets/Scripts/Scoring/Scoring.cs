using System;
using Domain;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    private int pointsOfPlayer;
    private int pointsOfAutoma;

    private Difficulty difficulty;

    [SerializeField]
    private TextMeshProUGUI playerPoints;

    [SerializeField]
    private TextMeshProUGUI automaPoints;

    private Empire empireOfPlayer;
    private Empire empireOfAutoma;

    [SerializeField]
    private Sprite[] empireIconTemplates;

    [SerializeField]
    private Image[] imageOfEmpireIcons;

    public void initPanel(string matchIdentificator)
    {
        empireOfPlayer = EmpireUtils.getEmpireFromString(matchIdentificator.Split("-")[0]);
        empireOfAutoma = EmpireUtils.getEmpireFromString(matchIdentificator.Split("-")[1]);
        imageOfEmpireIcons[0].sprite = getSpriteOfEmpire(empireOfPlayer);
        imageOfEmpireIcons[1].sprite = getSpriteOfEmpire(empireOfAutoma);
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

    public void backToOverview(){
        this.gameObject.SetActive(false);
    }

    private void updateUI()
    {
        print("new difficulty: " + difficulty);
    }

    private Sprite getSpriteOfEmpire(Empire empire)
    {
        return empireIconTemplates[((int)empire)];
    }
}
