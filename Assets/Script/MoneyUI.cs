using UnityEngine;
using UnityEngine.UI;

namespace Script
{
    public class MoneyUI : MonoBehaviour
    {

        public Text moneyText;
        private void Update()
        {
            moneyText.text = "Δενεγ: " + PlayerStats.Money.ToString();
        }
    }
}
