using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseExplain : MonoBehaviour
{
    // Start is called before the first frame update\
    public GameObject Explain;
 
    public void Close()
    {
        Explain.SetActive(false);
    }
}
