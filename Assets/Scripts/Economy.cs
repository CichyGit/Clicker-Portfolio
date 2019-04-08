using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Economy : MonoBehaviour
{
    public float Cash;
    public float CashPerClick;
    public float ComboBonus;
    public int NextComboBonusLvl;
    public float InTimeIncome;
    public float TotalCPC;

    public Shop sh;


    public void Start()
    {
        CashPerClick = 0.1f;
        InTimeIncome = 0.2f;
        StartCoroutine("InTime_Income");
        TotalCPC = (CashPerClick * sh.CashPerClickLvl) + ComboBonus;
    }

    public void Cash_PerClick()
    {
        Cash += TotalCPC;
 
        NextComboBonusLvl++;
        if (NextComboBonusLvl == 20)
        {
            NextComboBonusLvl = 0;
            ComboBonus += 0.1f;
        }
    }

    IEnumerator InTime_Income()
    {
        while (true)
        {
            Cash += InTimeIncome;
            yield return new WaitForSeconds(1f);
        }
    }

    public void Reset()
    {
        CashPerClick = 0.1f;
        InTimeIncome = 0.2f;
        Cash = 0;
    }
    public void Update()
    {
        TotalCPC = (CashPerClick * sh.CashPerClickLvl) + ComboBonus;
    }










}
