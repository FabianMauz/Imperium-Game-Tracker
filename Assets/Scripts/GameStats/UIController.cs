using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Playables;

namespace GameStats
{
    public class UIController : MonoBehaviour
    {
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

        private UI_STATE playerState;
        private UI_STATE automaState;

        [SerializeField]
        private TextMeshProUGUI playerButtonText;

        [SerializeField]
        private TextMeshProUGUI automaButtonText;

        void Start()
        {
            playerState = UI_STATE.CLASSIC;
            automaState = UI_STATE.CLASSIC;
            UpdateUI();
        }

        public void clickPlayerButton()
        {
            if (playerState == UI_STATE.CLASSIC)
            {
                playerState = UI_STATE.LEGENDS;
            }
            else
            {
                playerState = UI_STATE.CLASSIC;
            }
            UpdateUI();
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
            player_empires_classic.SetActive(playerState == UI_STATE.CLASSIC);
            player_empires_legends.SetActive(playerState == UI_STATE.LEGENDS);
            automa_empires_classic.SetActive(automaState == UI_STATE.CLASSIC);
            automa_empires_legends.SetActive(automaState == UI_STATE.LEGENDS);

            results_classic_classic.SetActive(
                playerState == UI_STATE.CLASSIC && automaState == UI_STATE.CLASSIC
            );
            results_legends_classic.SetActive(
                playerState == UI_STATE.LEGENDS && automaState == UI_STATE.CLASSIC
            );

            if (playerState == UI_STATE.CLASSIC)
            {
                playerButtonText.text = "Classic";
            }
            else
            {
                playerButtonText.text = "Legends";
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
