using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public Economy ec;
    public Shop sh;






    //All buttons 

    public void EarnMoney_Button()
    {
        ec.Cash_PerClick();
    }
    public void Upgrade_CashPerClick_Button()
    {
        sh.Upgrade_ClickPerLvl();
    }
    public void Reset_Button()
    {
        ec.Reset();
    }
}
