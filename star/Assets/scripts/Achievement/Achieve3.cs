using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Achieve3 : MonoBehaviour
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
        if (Achieve.achi3)
        {
            Origin.text = "평탄한 삶";
        
            badge.SetActive(true);
        }
    }
}
