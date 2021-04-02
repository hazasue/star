using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchieveAlarm : MonoBehaviour
{
    public static bool check1=true;
    public static bool check2=true;
    public static bool check3 = true;
    public static bool check4 = true;
    public static bool check5 = true;//알림을 한번 뜨게 위해 만든 체크
    public GameObject Alarm;
    public Text AlarmText;
    public GameObject Alarmicon;
    IEnumerator Disabled1(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        check1 = false;
        Alarm.SetActive(false);
      
        
    }
    IEnumerator Disabled2(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        check2 = false;
        Alarm.SetActive(false);


    }
    IEnumerator Disabled3(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        check3 = false;
        Alarm.SetActive(false);


    }
    IEnumerator Disabled4(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        check4 = false;
        Alarm.SetActive(false);


    }
    IEnumerator Disabled5(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        check5 = false;
        Alarm.SetActive(false);


    }
    // Start is called before the first frame update
    void Start()
    {

        if (Achieve.achi1com&&check1)
        {
            Alarm.SetActive(true);
           
            Alarmicon.SetActive(true);
            AlarmText.text = "업적달성! 업그레이드 완료";
            StartCoroutine(Disabled1(3.0f));
            
        }
        if(Achieve.achi2com&&check2)
        {
            Alarm.SetActive(true);
          
            Alarmicon.SetActive(true);
            AlarmText.text = "업적달성! 파산을 경험한사람";
            StartCoroutine(Disabled2(3.0f));
        }
        if (Achieve.achi3com && check3)
        {
            Alarm.SetActive(true);
           
            Alarmicon.SetActive(true);
            AlarmText.text = "업적달성! 나름 성공한사람";
            StartCoroutine(Disabled3(3.0f));
        }
        if (Achieve.achi4com && check4)
        {
            Alarm.SetActive(true);
            
            Alarmicon.SetActive(true);
            AlarmText.text = "업적달성! 영업의 신";
            StartCoroutine(Disabled4(3.0f));
        }
        if (Achieve.achi5com && check5)
        {
            Alarm.SetActive(true);
           
            Alarmicon.SetActive(true);
            AlarmText.text = "업적달성! 10만을 번사람";
            StartCoroutine(Disabled5(3.0f));
        }
    }

    // Update is called once per frame
    void Update()
    {
      
       
      
    }

}
