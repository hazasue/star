using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class unlockBlueRice : MonoBehaviour
{
    public static bool Purchaseblue; //purchase 했다는것을 알리기위한 변수
    public Image Origin;
    public Sprite ChangeSprite;
    public AudioSource Sell;
    public Text SellCom;

    void Start()
    {
        Purchaseblue = true;
        if (Manager.IsBlueRice == true)
        {
            SellCom.text = "SoldOut";
            Origin.sprite = ChangeSprite;
        }
    }
    public void unlockBlue()
    {
        if (Manager.money >= 2000&&Purchaseblue&&Manager.IsBlueRice==false)
        {
            Manager.IsBlueRice = true;
            Manager.money -= 2000;
            Upgradecheck.Upgradecom = true;
            SellCom.text = "SoldOut";
            Purchaseblue = false;
            Origin.sprite = ChangeSprite;
            Sell.Play();
            
        }
    
    }

 
}
