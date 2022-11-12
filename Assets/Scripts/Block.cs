using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Block : MonoBehaviour
{
    public int Value;
    public TextMeshPro PointsText;
       
    void Start()
    {        
        PointsText.SetText(Value.ToString());        
    }
        
}
