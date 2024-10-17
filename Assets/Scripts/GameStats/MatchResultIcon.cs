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
           
            ScoringController.instance.getScorePanelInOVerview().gameObject.SetActive(true);
            ScoringController.instance.getScorePanelInOVerview().initPanel(matchIdentificator);
        }
    }
}
