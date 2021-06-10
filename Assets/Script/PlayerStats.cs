using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static int Money;
    public int startMoney = 300;
    public Text MoneyHave;

    private void Start()
    {
        Money = startMoney;
    }

    private void Update()
    {
        MoneyHave.text = Money.ToString();
    }

}
