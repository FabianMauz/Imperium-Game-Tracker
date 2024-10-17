using Domain;
using Persistance;
using UnityEngine;

public class ScoringController : MonoBehaviour
{
    public static ScoringController instance { private set; get; }

    PersistApi persistor;

    [SerializeField]
    private Scoring scorePanelInOVerview;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            persistor = new PlayerPrefPersist();
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public Scoring getScorePanelInOVerview()
    {
        return scorePanelInOVerview;
    }

    public void saveMatch(Difficulty difficulty, Empire playerEmpire, Empire automaEmpire)
    {
        string playerAbbr = EmpireUtils.getStringOfEmpire(playerEmpire);
        string automaAbbr = EmpireUtils.getStringOfEmpire(automaEmpire);
        string matchIdentificator = playerAbbr + "-" + automaAbbr;
        persistor.saveResultOfMatch(matchIdentificator, ((int)difficulty)+1);
        scorePanelInOVerview.gameObject.SetActive(false);
    }
}
