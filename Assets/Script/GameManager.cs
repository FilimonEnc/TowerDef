using System.Collections;
using System.Collections.Generic;
using Script;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool gameEnded = false;
    void Update()
    {
        if(gameEnded)
            return;
        
        if (PlayerStats.Lives <= 0)
        {
            EndGame();
        }
    }

    private void EndGame()
    {
        gameEnded = true;
        Debug.Log("Конец игры");
    }
}
