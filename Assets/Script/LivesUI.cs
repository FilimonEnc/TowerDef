using UnityEngine;
using UnityEngine.UI;

namespace Script
{
    public class LivesUI : MonoBehaviour
    {
        public Text livesText;
    
    
        void Update()
        {
            livesText.text = "∆изней у базы: " + PlayerStats.Lives.ToString();
            
        }
    }
}
