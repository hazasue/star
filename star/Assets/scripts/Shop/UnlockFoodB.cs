using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockFoodB : MonoBehaviour
{
    public static bool purchaseFoodB = true; //purchase 했다는것을 알리기위한 변수
    public Image Origin;
    public Sprite ChangeSprite;
    public AudioSource Sell;
    public Text SellCom;
    void Start()
    {
        
        if (Manager.IsFoodB == true)
        {
            SellCom.text = "SoldOut";
            Origin.sprite = ChangeSprite;
        }
    }
    public void unlock()
    {
        if (Manager.money >= 2000&&purchaseFoodB&&Manager.IsFoodB==false)
        {
            Manager.IsFoodB = true;
            Manager.money -= 2000;
            Sell.Play();
            SellCom.text = "SoldOut";
            Upgradecheck.Upgradecom = true;
            purchaseFoodB=false;
            Origin.sprite = ChangeSprite;
           
        }
    }
}
