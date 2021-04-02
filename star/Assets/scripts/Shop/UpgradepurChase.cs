using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradepurChase : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource Sell;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Upgradered()
    {
        if (Manager.money >= 3000)
        {
            Money_manager.or_basic_money += 500;
            Manager.money -= 3000;
            Sell.Play();
        }
    }
    public void Upgradeblue()
    {
        if (Manager.money >= 3000)
        {
            Money_manager.Blue_basic_money += 500;
            Manager.money -= 3000;
            Sell.Play();
        }
    }
    public void UpgradeYellow()
    {
        if (Manager.money >= 3000)
        {
            Money_manager.Yellow_basic_money += 500;
            Manager.money -= 3000;
            Sell.Play();
        }
    }
}
