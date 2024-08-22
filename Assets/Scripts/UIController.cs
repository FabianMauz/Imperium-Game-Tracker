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
    private Dictionary<MAIN_UI_STATE, GameObject> mainObjectsMap =
        new Dictionary<MAIN_UI_STATE, GameObject>();

    private void Start()
    {
        mainObjectsMap.Add(MAIN_UI_STATE.MAIN_MENU, mainMenu);
        mainObjectsMap.Add(MAIN_UI_STATE.RESULT_OVERVIEW, resultOverview);
    }

    public void switchToMenu(string newState)
    {
        mainObjectsMap[currentState].GetComponent<Appear>().startDisappearing();
        this.currentState = (MAIN_UI_STATE)System.Enum.Parse(typeof(MAIN_UI_STATE), newState);
        mainObjectsMap[currentState].GetComponent<Appear>().startAppearing();
    }

    public enum MAIN_UI_STATE
    {
        MAIN_MENU,
        RESULT_OVERVIEW
    }
}
