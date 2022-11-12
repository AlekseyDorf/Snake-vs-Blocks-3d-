using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BonusLevel : MonoBehaviour
{
  
    public void Click()
    {
        
        StartCoroutine(Wait(3));
    }
    IEnumerator Wait(float delay)
    {
        yield return new WaitForSeconds(delay);
        gameObject.SetActive(false);
    }
}
