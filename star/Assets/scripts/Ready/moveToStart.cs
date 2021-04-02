using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moveToStart : MonoBehaviour
{
    public static bool shuterclick=false;

    void Start()
    {
		Manager.RedRice = 3;
		Manager.BlueRice = 3;
		Manager.YellowRice = 3;

		Manager.STICK1 = 3;
		Manager.STICK2 = 3;
		Manager.STICK3 = 3;
	}
    void Update()
    {

    }

    public void moveStart()
    {
        shuterclick = true;
		RandomCharacter.time = 0f;
		RandomCharacter.roundTime = 0;

    }
}
