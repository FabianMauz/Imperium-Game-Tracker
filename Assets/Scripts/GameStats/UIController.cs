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

        public void UpdateUI()
        {
            player_empires_classic.SetActive(playerState == UI_STATE.CLASSIC);
            player_empires_legends.SetActive(playerState == UI_STATE.LEGENDS);

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
