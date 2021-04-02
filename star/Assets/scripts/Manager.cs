using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
	public static int Day;

	public static int money;
	public static int day_money;
	public static int playTime;
	public static float stayTime;

	public static bool IsDrag;

	public static bool IsBlueRice;
	public static bool IsFoodA;
	public static bool IsFoodB;
	public static bool IsFoodC;
	public static bool IsOrangeRice;
    public static int countUpgrade; // 업그레이드 횟수를 알려주는 변수

	public static int RedRice;
	public static int BlueRice;
	public static int YellowRice;

	public static int STICK1;
	public static int STICK2;
	public static int STICK3;

	public static float RiceRefillTime;

	public static float StickRefillTime;
                                

    void Start()
    {
		Day = 20;

		money = 40000;
		playTime = 40;
		stayTime = 20f;

		IsDrag = false;

		IsBlueRice = false;
		IsOrangeRice = false;
		IsFoodA = false;
		IsFoodB = false;
		IsFoodC = false;

		RedRice = 3;
		BlueRice = 3;
		YellowRice = 3;


		STICK1 = 3;
		STICK2 = 3;
		STICK3 = 3;

		RiceRefillTime = 2f;

		StickRefillTime = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
