using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JungSan : MonoBehaviour
{
	public GameObject nextday;
	public GameObject nextdayBG;
	public GameObject backToReady;
	public GameObject goending;

	public GameObject nextDayBGLocation;
	public GameObject nextdayLocation;
	public GameObject backToReadyLocation;

	Vector2 nextDayBGLoc;
	Vector2 nextdaybutton;
	Vector2 backToReadyLoc;



	public Text shopClose;
	public Text totalMoney;
	public Text todayMoney;
	public Text totalValue;
	public Text todayValue;

	Transform ToNextDayUI;


	// Start is called before the first frame update
	void Start()
    {
		nextdaybutton = nextdayLocation.transform.position;
		backToReadyLoc = backToReadyLocation.transform.position;
		nextDayBGLoc = nextDayBGLocation.transform.position;

		ToNextDayUI = GameObject.Find("nextdayLoc").GetComponent<Transform>();

		Manager.RedRice = 3;
		Manager.BlueRice = 3;
		Manager.YellowRice = 3;


		Manager.STICK1 = 3;
		Manager.STICK2 = 3;
		Manager.STICK3 = 3;
	}

    // Update is called once per frame
    void Update()
    {
		if (RandomCharacter.IsEnd)
		{

			GameObject nextDayBG = Instantiate(nextdayBG, nextDayBGLoc, Quaternion.identity) as GameObject;
			nextDayBG.transform.parent = ToNextDayUI;
			nextDayBG.transform.localScale = new Vector2(8f, 5f);

			GameObject nextDay = Instantiate(nextday, nextdaybutton, Quaternion.identity) as GameObject;
			nextDay.transform.parent = ToNextDayUI;
			nextDay.transform.localScale = new Vector2(1f, 1f);

			GameObject BackToReady = Instantiate(backToReady, backToReadyLoc, Quaternion.identity) as GameObject;
			BackToReady.transform.parent = ToNextDayUI;
			BackToReady.transform.localScale = new Vector2(1f, 1f);

			RandomCharacter.moneyTodayValue = Manager.money - RandomCharacter.moneyToday;

			shopClose.text = Manager.Day + "일 영업종료!!";
			totalMoney.text = "총 수입";
			todayMoney.text = "오늘 수입";
			totalValue.text = "" + Manager.money + "원";
			todayValue.text = "" + RandomCharacter.moneyTodayValue + "원";

			RandomCharacter.IsEnd = false;

		}
	}
}
