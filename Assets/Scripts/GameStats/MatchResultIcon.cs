using Domain;
using UnityEngine;
using UnityEngine.UI;

namespace GameStats
{
    public class MatchResultIcon : MonoBehaviour
    {
        [SerializeField]
        private Empire empire;

        [SerializeField]
        private DifficultyChoiceMenu choiceMenu;

        [SerializeField]
        private Sprite[] starTemplates;

        [SerializeField]
        private Image starImage;

        [SerializeField]
        private string matchIdentificator;

        private void Update()
        {
            starImage.sprite = starTemplates[
                StatController.instance.getResultOfMatch(matchIdentificator)
            ];
        }

        public void openMenu()
        {
            // if (StatController.instance.state == State.OVERVIEW)
            // {
            //     StatController.instance.toggleState(State.SELECT_DIFFICULTY);
            //     StatController.instance.setCurrentMatchIdentificator(matchIdentificator);
            //     choiceMenu.UpdateUI();
            // }
            ScoringController.instance.getScorePanelInOVerview().gameObject.SetActive(true);
            ScoringController.instance.getScorePanelInOVerview().initPanel(matchIdentificator);
        }
    }
}
