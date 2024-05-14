using System.Collections.Generic;
using UnityEngine;
namespace GameStats {
    public class StatController : MonoBehaviour {
        public static StatController instance { private set; get; }
        public State state { private set; get; } = State.OVERVIEW;
        public GameChoice playerGameChoice{ private set; get; } = GameChoice.CLASSIC;
        public GameChoice automaGameChoice { private set; get; } = GameChoice.CLASSIC;
        private string currentMatchIdentificator="XX-XX";

        private Dictionary<string, int> persistance = new Dictionary<string, int>();

        public void setCurrentMatchIdentificator(string identificator) {
            this.currentMatchIdentificator = identificator;
        }

        public void setResultOfMatch(int difficulty) {
            if (!persistance.ContainsKey(currentMatchIdentificator)){
                persistance.Add(currentMatchIdentificator, difficulty);
            }else {
                persistance[currentMatchIdentificator] = difficulty;
            }
        }

        public int getResultOfMatch(string matchIdentificator) {
            if (persistance.ContainsKey(matchIdentificator)) {
                return persistance[matchIdentificator];
            }else {
                return 0;
            }
        }

        private void Awake() {
            if (instance == null) {
                instance = this;
                DontDestroyOnLoad(this);
            } else {
                Destroy(this.gameObject);
            }
        }

        public void toggleState(State newState) {
            this.state = newState;
        }
    }

    public enum State {
        SELECT_DIFFICULTY,
        OVERVIEW
    }

    public enum GameChoice {
        CLASSIC,
        LEGENDS,
        HOIRIZON
    }
}
