using UnityEngine;

namespace Script
{
    public class PlayerStats : MonoBehaviour
    {
        public static int Money;
        public int startMoney = 100;
        
        public static int Lives;
        public int startLives = 20;

        private void Start()
        {
            Money = startMoney;
            Lives = startLives;
        }
    
    

    }
}
