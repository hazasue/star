using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundOption : MonoBehaviour
{

    public AudioSource audioSource;
    public Slider slider;

    private float sliderVol = 0.5f;




    private void Start()
    {
        sliderVol = PlayerPrefs.GetFloat("sliderVol", 0.5f);
        slider.value = sliderVol;
        slider.value = audioSource.volume;
        
    }
    private void Update()
    {
        SoundSlider();
    }
    public void SoundSlider()
    {
        audioSource.volume = slider.value;
        sliderVol = slider.value;
        PlayerPrefs.SetFloat("sliderVol", sliderVol);
    }
}
