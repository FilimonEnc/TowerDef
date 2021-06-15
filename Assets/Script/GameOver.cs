using Script;

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text roundsText;

   
    private void OnEnable()
    {
        roundsText.text = "Ты прожил:" + PlayerStats.rounds.ToString() + " раундов";
        
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
        
    }
    
}
