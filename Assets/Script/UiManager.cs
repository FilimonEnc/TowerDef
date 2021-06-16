using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    public GameObject gameOverUI;
    public Animation gameoverAnim;
    
    
    // маленькая заготовочка которая потом будет фулл переделана. нужна для смены сцен при нажатии батанов.
    public void OpenLVLMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void OpenLVL1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void OpenLVL2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void OpenLVL3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
    public void OpenLVL4()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }
    public void OpenLVL5()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
    }
    public void BackMainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
  
    public void ExitGame()
    {
        Application.Quit();
    }

    public void GameOver()
    {
        EndGame();
    }
    public void EndGame()
    {
        GameManager.GameOver = true;
        gameOverUI.SetActive(true);
        gameoverAnim.Play();
        
      
    }

    public void NextWave()
    {
        if(WaveSpawner.instance.countdown !=0)
            WaveSpawner.instance.countdown = 0.1f;
    }
    

}
