using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public Button[] buttons;
    int levelUnlock;
    void Start()
    {
        levelUnlock = PlayerPrefs.GetInt("levels", 1);
        for(int i=0; i<buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }
        for(int i = 0; i < levelUnlock; i++)
        {
            buttons[i].interactable = true;
        }
    }

    public void LoadLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }
    public void Reset()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }
        PlayerPrefs.DeleteAll();
        buttons[0].interactable = true;
    }
    public void SwitchLevel(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
    
}
