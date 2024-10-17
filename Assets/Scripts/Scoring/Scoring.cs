using System;
using Domain;
using GameStats;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    private int pointsOfPlayer;
    private int pointsOfAutoma;

    private Difficulty difficulty = Difficulty.OVERLORD;

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

    [SerializeField]
    private TextMeshProUGUI[] empireNames;

    [SerializeField]
    private DifficultyButton[] difficultyButtons;

    public void initPanel(string matchIdentificator)
    {
        empireOfPlayer = EmpireUtils.getEmpireFromString(matchIdentificator.Split("-")[0]);
        empireOfAutoma = EmpireUtils.getEmpireFromString(matchIdentificator.Split("-")[1]);
        imageOfEmpireIcons[0].sprite = getSpriteOfEmpire(empireOfPlayer);
        imageOfEmpireIcons[1].sprite = getSpriteOfEmpire(empireOfAutoma);
        empireNames[0].text = Localisation.getEmpireName(empireOfPlayer, Language.GERMAN);
        empireNames[1].text = Localisation.getEmpireName(empireOfAutoma, Language.GERMAN);
        updateUI();
    }

    public void closePanel()
    {
        this.gameObject.SetActive(false);
    }

    public void saveGameResult()
    {
        ScoringController.instance.saveMatch(difficulty, empireOfPlayer, empireOfAutoma);
         FindAnyObjectByType<ResultsUiController>(). UpdateUI();
    }

    public void setDifficulty(string difficulty)
    {
        this.difficulty = (Difficulty)Enum.Parse(typeof(Difficulty), difficulty);
        updateUI();
    }

    public void changePoints()
    {
        updateUI();
    }

    public void setDifficulty(int diffuícultyId) { }

    private void updateUI()
    {
        foreach (DifficultyButton button in difficultyButtons)
        {
            button.updateUI(difficulty);
        }
    }

    private Sprite getSpriteOfEmpire(Empire empire)
    {
        return empireIconTemplates[((int)empire)];
    }
}
