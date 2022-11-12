using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Food : MonoBehaviour
{
    public int Value;
    public TextMeshPro PointsText;

    void Start()
    {
        PointsText.SetText(Value.ToString());
    }
}
