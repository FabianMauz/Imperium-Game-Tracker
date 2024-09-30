using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Scoring : MonoBehaviour{
    private string pointsFromPlayer="0";
    private string pointsFromAutoma="0";

    [SerializeField]
    private TextMeshProUGUI inputPlayer;
   public void saveGameResult(){
print(":"+inputPlayer.text);
   }
   
}
