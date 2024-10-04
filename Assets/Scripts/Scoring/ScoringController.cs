using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoringController : MonoBehaviour
{
    public static ScoringController instance { private set; get; }

    [SerializeField]
    private Scoring scorePanelInOVerview;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
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
}
