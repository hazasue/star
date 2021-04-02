using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Achieve1 : MonoBehaviour
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
        if(Achieve.achi1)
        {
            Origin.text = "업적달성! 강화 완료";
            badge.SetActive(true);
        }
    }
}
