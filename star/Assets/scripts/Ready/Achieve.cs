using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achieve : MonoBehaviour
{
    public static bool achi1;
    public static bool achi1com = false;//알림을 위해 만든 정적변수(1번만 뜨게 하기 위함)
    public static bool achi2=false;
    public static bool achi2com = false;
    public static bool achi3=false;
    public static bool achi3com = false;
    public static bool achi4=false;
    public static bool achi4com = false;
    public static bool achi5;
    public static bool achi5com = false;
    public static bool achi6;


    int dayday;//n 회차를 세기 위해 만든 변수
    
     void nonUpgrade() //아무것도 장비를 강화하지 않았을 경우 생기는 업적
    {
        if (Manager.countUpgrade>=1)
        {
            achi1 = true;
          
            achi1com = true;
        }

    }
    void badending()//업그레이드를 모두 마쳤을시, 나오는 업적
    {
        if (achi2 == true)
        {

            achi2com = true;

        }
    }

        void goodending()
        {
            if(achi3==true)
            {
            achi3com = true;
            }
        }

    void greatending()
    {
        if(achi4==true)
        {
            achi4com = true;
        }
    }

    void moneymillion() 
    {
        if (Manager.money == 100000) 
        { achi5 = true;
            achi5com = true;
        }
            
            }
      
        
    void Livecount()
    {
        if(Manager.Day==0)
        {
            dayday = dayday + 1;
            if(dayday==1)
            {
                Debug.Log("업적달성! 경형 회차2번째");
            }
            if(dayday==10)
            {
                Debug.Log("업적달성! 경영회차 10번째");
            }
        }
    }
    
    void Start()
    {
        achi1 = false;
       
    
        
        nonUpgrade();
        badending();
        goodending();
        moneymillion();
        greatending();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
