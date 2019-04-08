using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public float CashPerClickLvl;

    public void Start()
    {
        CashPerClickLvl = 1;
    }

    public void Upgrade_ClickPerLvl()
    {
        CashPerClickLvl += 1.5f;
    }

}
