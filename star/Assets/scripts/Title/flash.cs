using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flash : MonoBehaviour
{
    public GameObject flashtext;
    float time;
    bool check1;
    bool check2;
   
    void Start()
    {
        check1 = true;
        check2 = true;
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        if (time > 0.5&&check1)
        {
            flashtext.SetActive(false);
            check1 = false;
        }
        else if (time > 1&&check2)
        {
            flashtext.SetActive(true);
            check2 = false;
           
        }
        else if(time>1.1)
        {
            time = 0;
            check1 = true;
            check2 = true;
        }
       
    }
}
