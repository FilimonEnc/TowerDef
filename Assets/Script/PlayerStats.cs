using System;
using UnityEngine;

namespace Script
{
    public class PlayerStats : MonoBehaviour
    {
        public static int Money;
        public int startMoney = 100;
        
        public static int Lives;
        public int startLives = 20;
        public static int rounds;
        

        private void Start()
        {
            Money = startMoney;
            Lives = startLives;
            rounds = 0;
            
        }

        private void Update()
        {
            if (Lives < 0)
                Lives = 0;
        }
    }
}
