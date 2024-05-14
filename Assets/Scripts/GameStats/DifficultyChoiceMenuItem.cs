using UnityEngine;
namespace GameStats {
    public class DifficultyChoiceMenuItem : MonoBehaviour {
        [SerializeField]
        private int difficulty;

        public void selectDifficulty() {
            StatController.instance.toggleState(State.OVERVIEW);
            StatController.instance.setResultOfMatch(difficulty);
        }
    }
}
