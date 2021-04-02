using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class unlockfoodA : MonoBehaviour
{
    public static bool purchaseFoodA=true;
    public Image Origin;
    public Sprite ChangeSprite;
    public AudioSource Sell;
    public Text SellCom;

    void Start()
    {
        
        if (Manager.IsFoodA == true)
        {
            SellCom.text = "SoldOut";
            Origin.sprite = ChangeSprite;
        }
    }
    public void unlockFoodA()
    {
        if (Manager.money >= 2000&&purchaseFoodA&&Manager.IsFoodA==false)
        {
            Manager.IsFoodA = true;
            Manager.money -= 2000;
            SellCom.text = "SoldOut";
            Upgradecheck.Upgradecom = true;
            purchaseFoodA = false;
            Origin.sprite = ChangeSprite;
            Sell.Play();
        }
    }
}
