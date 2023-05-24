using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCounter : MonoBehaviour
{
    [SerializeField] public int hoverCounter { get; private set; }
    public void OnHoverCounter()
    {
        Debug.Log("Entered Cube");
        hoverCounter++;
        Debug.Log(hoverCounter);

        if (hoverCounter == 10)
        {
            if (GameManager.instance.currentState == GameManager.GameState.InGame)
            {
                GameManager.instance.currentState = GameManager.GameState.GameOver;
            }
        }

    }
}
