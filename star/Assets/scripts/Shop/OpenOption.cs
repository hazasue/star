using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenOption : MonoBehaviour
{

    public GameObject startOption;
    public GameObject Back;
    public GameObject Option;
   public void Open()
    {
        Option.SetActive(true);
    }

    public void Close()
    {
        Option.SetActive(false);
    }
}
