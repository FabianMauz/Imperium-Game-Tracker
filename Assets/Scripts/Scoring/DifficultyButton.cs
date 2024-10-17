
using Domain;
using UnityEngine;

public class DifficultyButton : MonoBehaviour
{
    [SerializeField]
    private GameObject shadow;
    [SerializeField] 
    private Difficulty difficulty;
    public void updateUI(Difficulty d) {
        shadow.SetActive(d!=difficulty);
     }
}
