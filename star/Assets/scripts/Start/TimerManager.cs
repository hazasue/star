using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerManager : MonoBehaviour
{
	public Slider charTimer;

	float time;
    // Start is called before the first frame update
    void Start()
    {
		charTimer.maxValue = Manager.stayTime - 1;
		charTimer.value = Manager.stayTime - 1;
		time = 0f;
    }

    // Update is called once per frame
    void Update()
    {
		time += Time.deltaTime;
		charTimer.value = Manager.stayTime - time - 1;
    }
}
