using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickBadgeGo : MonoBehaviour
{
    public GameObject Achievement;
    public GameObject Badge;
    public GameObject big;
    public GameObject small;
    public GameObject anotherbig;
    public GameObject anothersmall;
    public void ClickA()
    {
        Achievement.SetActive(false);
        Badge.SetActive(true);
        big.SetActive(true);
        small.SetActive(false);
        anotherbig.SetActive(false);
        anothersmall.SetActive(true);
    }
}
