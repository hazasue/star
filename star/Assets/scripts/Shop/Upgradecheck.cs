using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Upgradecheck : MonoBehaviour
{
    public static bool Upgradecom;
    public void checkcheck()
    {
        //onclick 컴포넌트에 넣을 함수
        if (Upgradecom)
        {
            Manager.countUpgrade += 1;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Upgradecom = false;
    }

  
}
