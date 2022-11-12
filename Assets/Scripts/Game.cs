using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public Player Controls;
    public GameObject Loss;
    public AudioSource _BGM;
    public AudioSource loseAudio;
    private void Awake()
    {
        _BGM = GetComponent<AudioSource>();
    }
    public enum State
    {
        Playing,
        Won,
        Loss,
    }

    public State CurrentState { get; private set; }

    public void OnPlayerDied()
    {
        if (CurrentState != State.Playing) return;
        CurrentState = State.Loss;
        Controls.enabled = false;
        Debug.Log("Game Over!");
        loseAudio.Play();
        Loss.SetActive(true);
    }

    public void OnPlayerWon()
    {
        if (CurrentState != State.Playing) return;
        CurrentState = State.Won;
        Controls.enabled = false;
        Debug.Log("You Won!");
    }
}
