using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Playables;

namespace GameStats
{
    public class ResultsUiController : MonoBehaviour
    {
        [SerializeField]
        private GameObject resultOverview;

        [SerializeField]
        private GameObject player_empires_classic;

        [SerializeField]
        private GameObject player_empires_legends;

        [SerializeField]
        private GameObject automa_empires_classic;

        [SerializeField]
        private GameObject automa_empires_legends;

        [SerializeField]
        private GameObject results_classic_classic;

        [SerializeField]
        private GameObject results_legends_classic;

        [SerializeField]
        private GameObject results_classic_legends;

        [SerializeField]
        private GameObject results_legends_legends;

        private UI_STATE playerState;
        private UI_STATE automaState;

        [SerializeField]
        private TextMeshProUGUI playerButtonText;

        [SerializeField]
        private TextMeshProUGUI automaButtonText;

        private Dictionary<UI_STATE, GameObject> playerEmpireMap =
            new Dictionary<UI_STATE, GameObject>();

        void Start()
        {
            playerState = UI_STATE.CLASSIC;
            automaState = UI_STATE.CLASSIC;
            playerEmpireMap.Add(UI_STATE.CLASSIC, player_empires_classic);
            playerEmpireMap.Add(UI_STATE.LEGENDS, player_empires_legends);
            UpdateUI();
        }

        public void clickPlayerButton()
        {
            resultOverview.GetComponent<Appear>().cancelAllApprearing();
            playerEmpireMap[playerState].GetComponent<Appear>().startDisappearing();
            selectNextPlayerEmpireGroup();
            playerEmpireMap[playerState].SetActive(true);
            playerEmpireMap[playerState].GetComponent<Appear>().startAppearing();
            UpdateUI();
        }

        private void selectNextPlayerEmpireGroup()
        {
            if (playerState == UI_STATE.CLASSIC)
            {
                playerState = UI_STATE.LEGENDS;
            }
            else
            {
                playerState = UI_STATE.CLASSIC;
            }
        }

        public void clickAutomaButton()
        {
            if (automaState == UI_STATE.CLASSIC)
            {
                automaState = UI_STATE.LEGENDS;
            }
            else
            {
                automaState = UI_STATE.CLASSIC;
            }
            UpdateUI();
        }

        public void UpdateUI()
        {
            automa_empires_classic.SetActive(automaState == UI_STATE.CLASSIC);
            automa_empires_legends.SetActive(automaState == UI_STATE.LEGENDS);

            updateGameResults();
            updateButtonTexts();
        }

        private void updateGameResults()
        {
            results_classic_classic.SetActive(
                playerState == UI_STATE.CLASSIC && automaState == UI_STATE.CLASSIC
            );
            results_classic_legends.SetActive(
                playerState == UI_STATE.CLASSIC && automaState == UI_STATE.LEGENDS
            );
            results_legends_classic.SetActive(
                playerState == UI_STATE.LEGENDS && automaState == UI_STATE.CLASSIC
            );
            results_legends_legends.SetActive(
                playerState == UI_STATE.LEGENDS && automaState == UI_STATE.LEGENDS
            );
        }

        private void updateButtonTexts()
        {
            if (playerState == UI_STATE.CLASSIC)
            {
                playerButtonText.text = "Classic";
            }
            else
            {
                playerButtonText.text = "Legends";
            }
            if (automaState == UI_STATE.CLASSIC)
            {
                automaButtonText.text = "Classic";
            }
            else
            {
                automaButtonText.text = "Legends";
            }
        }
    }

    public enum UI_STATE
    {
        CLASSIC,
        LEGENDS,
        HORIZONTS
    }
}
