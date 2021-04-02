using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReMoveToReady : MonoBehaviour
{
    public static bool game_clear = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void reMoveToReady()
	{
        Manager.day_money = 0;
		Manager.Day += 1;
        SceneManager.LoadScene("Ready");
        game_clear = true;
	}
}
