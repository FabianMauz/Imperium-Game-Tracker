using Domain;
using UnityEngine;

public class ResultColumn : MonoBehaviour
{
    [SerializeField]
    private Empire empire;

    public Empire getEmpire()
    {
        return empire;
    }
}
