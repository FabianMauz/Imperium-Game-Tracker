using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField]
    private GameObject mainMenu;

    [SerializeField]
    private GameObject resultOverview;
    private MAIN_UI_STATE currentState = MAIN_UI_STATE.MAIN_MENU;

    public void switchToMenu(string newState)
    {
        this.currentState =  (MAIN_UI_STATE)System.Enum.Parse(typeof(MAIN_UI_STATE), newState);
        updateUI();
    }

    private void updateUI()
    {
        mainMenu.SetActive(currentState == MAIN_UI_STATE.MAIN_MENU);
        resultOverview.SetActive(currentState == MAIN_UI_STATE.RESULT_OVERVIEW);
    }

    public enum MAIN_UI_STATE
    {
        MAIN_MENU,
        RESULT_OVERVIEW
    }
}
