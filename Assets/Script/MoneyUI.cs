using UnityEngine;
using UnityEngine.UI;

namespace Script
{
    public class MoneyUI : MonoBehaviour
    {

        public Text moneyText;
        private void Update()
        {
            moneyText.text = "�����: " + PlayerStats.Money.ToString();
        }
    }
}
