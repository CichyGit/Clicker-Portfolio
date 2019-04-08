using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextControl : MonoBehaviour
{
    public Text Money_Text;
    public Text InTimeIncome_Text;
    public Text Bonus_Text;
    public Text CashPerClick_Text;
    public Economy ec;


    public void Update()
    {
        Money_Text.text = ec.Cash.ToString();
        InTimeIncome_Text.text = ec.InTimeIncome.ToString();
        Bonus_Text.text = ec.ComboBonus.ToString();
        CashPerClick_Text.text = ec.TotalCPC.ToString();
    }
}
