using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavigateMenu : MonoBehaviour
{
    public void SwitchLevel(string SceneName)
    {
        UnnlockLevel();
        SceneManager.LoadScene(SceneName);        
    }

    public void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void UnnlockLevel()
    {
        int currentlevel = SceneManager.GetActiveScene().buildIndex;
        if(currentlevel >= PlayerPrefs.GetInt("levels"))
        {
            PlayerPrefs.SetInt("levels",currentlevel);
        }
    }
}
