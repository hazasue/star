using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayCount : MonoBehaviour
{
	public Text dayCount;
    string day;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        day = Manager.Day.ToString();

        if (Manager.Day != 30)
            dayCount.text = day;

        else
            dayCount.text = "<color=#ff0000>" + day + "</color>";
    }
}
