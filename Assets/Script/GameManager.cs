using System;
using System.Collections;
using System.Collections.Generic;
using Script;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    
    public GameObject gameOverUI;
    public static bool GameOver;
    public Animation gameoverAnim;

    private void Start()
    {
        GameOver = false;
    }

    void Update()
    {
        if(GameOver)
            return;
        
      
        
        if (PlayerStats.Lives <= 0)
        {
            EndGame();
        }
    }

    public void EndGame()
    {
        GameOver = true;
        gameoverAnim.Play();
        gameOverUI.SetActive(true);
    }
}
