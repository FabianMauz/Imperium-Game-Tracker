using System.Collections;
using System.Collections.Generic;
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
