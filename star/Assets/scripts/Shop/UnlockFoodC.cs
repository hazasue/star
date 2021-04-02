using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockFoodC : MonoBehaviour
{
    public static bool purchaseFoodC=true;
    public Image Origin;
    public Sprite ChangeSprite;
    public AudioSource Sell;
    public Text SellCom;
    void Start()
    {
        purchaseFoodC = true;
        if (Manager.IsFoodC == true)
        {
            SellCom.text = "SoldOut";
            Origin.sprite = ChangeSprite;
        }
    }
    public void unlockFoodC()
    {
        if (Manager.money >= 3000&&purchaseFoodC&&Manager.IsFoodC==false)
        {
            Manager.IsFoodC = true;
            Manager.money -= 3000;
            SellCom.text = "SoldOut";
            Upgradecheck.Upgradecom = true;
            Sell.Play();
            purchaseFoodC = false;
            Origin.sprite = ChangeSprite;
            
        }
    }

}
