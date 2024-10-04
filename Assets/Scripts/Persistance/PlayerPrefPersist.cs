using UnityEngine;

namespace Persistance
{
    public class PlayerPrefPersist : PersistApi
    {
        public int loadResultOfMatch(string matchIdentificator)
        {
            return PlayerPrefs.GetInt(matchIdentificator, 0);
        }

        public void saveResultOfMatch(string matchIdentificator, int difficulty)
        {
            PlayerPrefs.SetInt(matchIdentificator, difficulty);
        }
    }
}
