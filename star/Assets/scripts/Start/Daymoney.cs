using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Daymoney : MonoBehaviour
{
    // Start is called before the first frame update
    public Text Day_money;
    public static bool Today_money;

    void Start()
    {

        Day_money.text = "" + Manager.day_money;

    }

    // Update is called once per frame
    void Update()
    {

    }
}
