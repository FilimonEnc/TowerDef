using UnityEngine;
using UnityEngine.UI;

namespace Script
{
    public class TowerScript : MonoBehaviour
    {
        private static readonly int HealthTower = 30;
        public Text healthText;
        public GameObject enemy;


        private void Start()
        {
            healthText.text = HealthTower.ToString();
            Base();

        }

        void Base()
        {
            BaseDamage();
            BaseDied();
        }

        void BaseDamage()
        {
            Debug.Log("Damage taken");
            //if(enemy)    
    
        }
    
    
        void BaseDied()
        {
            Debug.Log("Tron died");
        }

    }
}
