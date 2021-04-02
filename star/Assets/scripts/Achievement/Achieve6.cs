using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Achieve6 : MonoBehaviour
{
    public Text Origin;
    public Image Testimage;
    public Sprite Testsprite;
    public GameObject badge;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Achieve.achi6)
        {
            Origin.text = "All Upgrade";
            Testimage.sprite = Testsprite;
            badge.SetActive(true);
        }
    }
}
