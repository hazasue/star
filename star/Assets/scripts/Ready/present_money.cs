using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class present_money : MonoBehaviour
{
    public Text money;

    void Start()
    {

    }

    void Update()
    {
        money.text = "" + Manager.money;
    }
}
