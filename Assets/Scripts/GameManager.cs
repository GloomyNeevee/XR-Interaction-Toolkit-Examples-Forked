using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum GameState
    {
        NONE,
        MainMenu,
        InGame,
        Paused,
        GameOver
    }

    public GameState currentState;
    
    public static GameManager instance;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogWarning("More than one instance of GameManager found!");
            Destroy(gameObject);
        }
        
    }

    private void Start()
    {
         GoToDefaultState();
    }

    // Set the current state to InGame
    public void GoToDefaultState()
    {
        currentState = GameState.InGame;
    }


    // Set the current state to the new state
    public void SwitchGameState(GameState newState)
    {
        if (currentState == newState)
        {
            Debug.LogWarning("Trying to switch to the same game state!");
            return;
        }
        
        currentState = newState;

        switch (newState)
        {
            case GameState.NONE:
                break;
            case GameState.MainMenu:
                // TODO: Add code to switch to the main menu
                break;
            case GameState.InGame:
                // TODO: Add code to switch to the in-game state
                break;
            case GameState.Paused:
                break;
            case GameState.GameOver:
                // TODO: Add code to switch to the game over state
                break;
        }

    }


}
