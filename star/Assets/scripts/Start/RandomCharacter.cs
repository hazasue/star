using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class RandomCharacter : MonoBehaviour
{
	void makeCharFeel(GameObject charObj, GameObject charImg, GameObject pos, Transform Parent)
	{
		charObj = Instantiate(charImg, pos.transform.position, Quaternion.identity) as GameObject;
		charObj.transform.parent = Parent;
		charObj.transform.localScale = new Vector3(3.05f, 3.825f, 1f);
		Destroy(charObj, 0.5f);
	}

	void makeCoin(GameObject coin, GameObject coinImg, GameObject pos, Transform Parent)
	{
		coin = Instantiate(coinImg, pos.transform.position, Quaternion.identity) as GameObject;
		coin.transform.parent = Parent;
		coin.transform.localScale = new Vector2(0.5f, 2.1f);
		Destroy(coin, 1.5f);
	}

	public static float time;
	public static float roundTime;

	//위치별 캐릭터의 머무르는 시간
	public static float charStay1;
	public static float charStay2;
	public static float charStay3;

	//캐릭터 최초 생성 여부 관리
	bool IsOne;
	bool IsTwo;
	bool IsThree;

	bool Isone;
	bool Istwo;
	bool Isthree;

	string SetScale;
	string SetScale2;
	string SetScale3;
	string charFeel;

	public static string cf1;
	public static string cf2;
	public static string cf3;

	public static bool IsPause;

	//시간이 지남에 따라 캐릭터 삭제, 생성 관리
	public static bool timeFlow1;
	public static bool timeFlow2;
	public static bool timeFlow3;

	public static bool CharProduce1;
	public static bool CharProduce2;
	public static bool CharProduce3;

	//캐릭터 이미지 지정
	public GameObject char1;
	public GameObject char2;
	public GameObject char3;
	public GameObject char4;
	public GameObject char5;
	public GameObject char6;
	public GameObject char7;
	public GameObject char8;
	public GameObject char9;

	public GameObject char11;
	public GameObject char12;
	public GameObject char13;
	public GameObject char14;
	public GameObject char15;
	public GameObject char16;
	public GameObject char17;
	public GameObject char18;
	public GameObject char19;

	public GameObject char21;
	public GameObject char22;
	public GameObject char23;
	public GameObject char24;
	public GameObject char25;
	public GameObject char26;
	public GameObject char27;
	public GameObject char28;
	public GameObject char29;


	public GameObject feeling1;
	public GameObject feeling2;
	public GameObject feeling3;

	public static GameObject Feel1;
	public static GameObject Feel2;
	public static GameObject Feel3;

	public GameObject Food1;
	public GameObject Food2;
	public GameObject Food3;
	public GameObject Food4;
	public GameObject Food5;
	public GameObject Food6;
	public GameObject Food7;
	public GameObject Food8;
	public GameObject Food9;
	public GameObject Food10;
	public GameObject Food11;
	public GameObject Food12;
	public GameObject Food13;
	public GameObject Food14;
	public GameObject Food15;
	public GameObject Food16;
	public GameObject Food17;
	public GameObject Food18;
	public GameObject Food19;
	public GameObject Food20;
	public GameObject Food21;
	public GameObject Food22;
	public GameObject Food23;
	public GameObject Food24;
	public GameObject Food25;
	public GameObject Food26;
	public GameObject Food27;

	public GameObject delImg;

	//랜덤으로 지정된 이미지를 담을 오브젝트
	GameObject character;

	GameObject food;
	GameObject fooD2;
	GameObject fooD3;

	GameObject hchar11;
	GameObject hchar22;
	GameObject hchar33;

	public GameObject hchar1;
	public GameObject hchar2;
	public GameObject hchar3;
	public GameObject hchar4;
	public GameObject hchar5;
	public GameObject hchar6;
	public GameObject hchar7;
	public GameObject hchar8;
	public GameObject hchar9;

	//캐릭터가 생성될 위치 지정
	public GameObject LocChar1;
	public GameObject LocChar2;
	public GameObject LocChar3;

	public static GameObject LocationChar1;
	public static GameObject LocationChar2;
	public static GameObject LocationChar3;


	public GameObject LocFood1;
	public GameObject LocFood2;
	public GameObject LocFood3;
	public GameObject LocFood12;
	public GameObject LocFood13;
	public GameObject LocFood22;
	public GameObject LocFood23;
	public GameObject LocFood32;
	public GameObject LocFood33;

	//생성된 캐릭터 이미지 관리
	public static GameObject Char1;
	public static GameObject Char2;
	public static GameObject Char3;

	public static GameObject food1;
	public static GameObject food12;
	public static GameObject food13;
	public static GameObject food2;
	public static GameObject food22;
	public static GameObject food23;
	public static GameObject food3;
	public static GameObject food32;
	public static GameObject food33;

	//해금 시킬 게임 오브젝트
	public GameObject Blue;
	public GameObject BlueLoc;

	public GameObject FoodA;
	public GameObject FoodB;
	public GameObject FoodC;
	public GameObject FoodALoc;
	public GameObject FoodBLoc;
	public GameObject FoodCLoc;

	Vector2 BluePos;
	Vector2 FoodAPos;
	Vector2 FoodBPos;
	Vector2 FoodCPos;

	bool isBlue;
	bool isFoodA;
	bool isFoodB;
	bool isFoodC;

	//동전 생성 여부
	bool oneOne;
	bool oneTwo;
	bool oneThree;
	bool twoOne;
	bool twoTwo;
	bool twoThree;
	bool threeOne;
	bool threeTwo;
	bool threeThree;


	//클리어 후 버튼 생성
	public GameObject nextday;
	public GameObject nextdayBG;
	public GameObject backToReady;
	public GameObject goending;

	public GameObject nextDayBGLocation;
	public GameObject nextdayLocation;
	public GameObject backToReadyLocation;

	GameObject charFeeling;

	Vector2 nextDayBGLoc;
	Vector2 nextdaybutton;
	Vector2 backToReadyLoc;
	public static bool IsEnd;

	public Slider charTimer1;
	public Slider charTimer2;
	public Slider charTimer3;
	public Slider playTimer;

	bool IsTimer1;
	bool IsTimer2;
	bool IsTimer3;

	bool charFeeling1;
	bool charFeeling2;
	bool charFeeling3;

	float CharTimer1;
	float CharTime1;

	float CharTimer2;
	float CharTime2;

	float CharTimer3;
	float CharTime3;

	//parent 위치 정의
	Transform canvas;
	Transform CharacterManager;
	Transform FoodManager;
	Transform UIlocation;
	Transform basicFood;
	Transform ToNextDayUI;
	Transform StickBox;
	//돈 체크
	public static int moneyToday;
	public static int moneyTodayValue;

	public Text shopClose;
	public Text totalMoney;
	public Text todayMoney;
	public Text totalValue;
	public Text todayValue;

	bool limitTimer;

	public GameObject RedTimer;
	Transform RT;

	GameObject coin;
	Transform coinBox;
	public GameObject coinImg;

	public static bool delete1;
	public static bool delete2;
	public static bool delete3;


	// Start is called before the first frame update
	void Start()
	{
		delete1 = false;
		delete2 = false;
		delete3 = false;

		IsOne = true;
		IsTwo = true;
		IsThree = true;

		Isone = true;
		Istwo = true;
		Isthree = true;

		IsPause = true;

		timeFlow1 = false;
		timeFlow2 = false;
		timeFlow3 = false;

		CharProduce1 = true;
		CharProduce2 = true;
		CharProduce3 = true;

		charFeeling1 = true;
		charFeeling2 = true;
		charFeeling3 = true;

		limitTimer = true;


		time = 0f;
		roundTime = 0f;
		charStay1 = 0f;
		charStay2 = 0f;
		charStay3 = 0f;

		BluePos = BlueLoc.transform.position;
		FoodAPos = FoodALoc.transform.position;
		FoodBPos = FoodBLoc.transform.position;
		FoodCPos = FoodCLoc.transform.position;

		isBlue = true;
		isFoodA = true;
		isFoodB = true;
		isFoodC = true;

		CharTimer1 = 0f;
		CharTimer2 = 0f;
		CharTimer3 = 0f;

		CharTime1 = 0f;
		CharTime2 = 0f;
		CharTime3 = 0f;

		CharacterManager = GameObject.Find("characterManager").GetComponent<Transform>();
		FoodManager = GameObject.Find("CreatedFood").GetComponent<Transform>();
		canvas = GameObject.Find("Canvas").GetComponent<Transform>();
		UIlocation = GameObject.Find("UILocation").GetComponent<Transform>();
		basicFood = GameObject.Find("BasicFood").GetComponent<Transform>();
		ToNextDayUI = GameObject.Find("nextdayLoc").GetComponent<Transform>();
		StickBox = GameObject.Find("StickBox").GetComponent<Transform>();
		RT = GameObject.Find("timeLimit").GetComponent<Transform>();
		coinBox = GameObject.Find("coinBox").GetComponent<Transform>();

		nextdaybutton = nextdayLocation.transform.position;
		backToReadyLoc = backToReadyLocation.transform.position;
		nextDayBGLoc = nextDayBGLocation.transform.position;
		IsEnd = true;

		time = 0f;

		IsTimer1 = true;
		IsTimer2 = true;
		IsTimer3 = true;

		LocationChar1 = LocChar1;
		LocationChar2 = LocChar2;
		LocationChar3 = LocChar3;

		playTimer.maxValue = Manager.playTime;
		playTimer.value = Manager.playTime;

		moneyToday = Manager.money;
		oneOne = false;
		oneTwo = false;
		oneThree = false;
		twoOne = false;
		twoTwo = false;
		twoThree = false;
		threeOne = false;
		threeTwo = false;
		threeThree = false;
	}

	// Update is called once per frame
	void Update()
	{
		Debug.Log(food1);
		Debug.Log(food12);
		Debug.Log(food13);
		playTimer.value -= Time.deltaTime;
		if (IsPause)
		{
			time += Time.deltaTime;
			roundTime = Mathf.Round(time);
		}
		int randomSelect = Random.Range(1, 10);

		if (Manager.IsFoodA)
		{
			if (isFoodA)
			{
				GameObject foodA = Instantiate(FoodA, FoodAPos, Quaternion.identity) as GameObject;
				foodA.transform.parent = StickBox;
				foodA.transform.localScale = new Vector3(1f, 0.825f, 1f);

				isFoodA = false;
			}
		}

		if (Manager.IsFoodB)
		{
			if (isFoodB)
			{
				GameObject foodB = Instantiate(FoodB, FoodBPos, Quaternion.identity) as GameObject;
				foodB.transform.parent = StickBox;
				foodB.transform.localScale = new Vector3(1.7375f, 0.48f, 1f);

				isFoodB = false;
			}
		}

		if (Manager.IsFoodC)
		{
			if (isFoodC)
			{
				GameObject foodC = Instantiate(FoodC, FoodCPos, Quaternion.identity) as GameObject;
				foodC.transform.parent = StickBox;
				foodC.transform.localScale = new Vector3(1f, 0.825f, 1f);

				isFoodC = false;
			}
		}

		if (Manager.IsBlueRice)
		{
			if (isBlue)
			{
				GameObject blue = Instantiate(Blue, BluePos, Quaternion.identity) as GameObject;
				blue.transform.parent = basicFood;
				blue.transform.localScale = new Vector3(1.424812f, 1.099322f, 1f);

				isBlue = false;
			}
		}

		if (Feel1)
		{
			if (IsTimer1)
			{
				charTimer1.maxValue = Manager.stayTime - 1;
				charTimer1.value = Manager.stayTime - 1;
				CharTimer1 = 0f;
				IsTimer1 = false;
			}
			if (timeFlow1)
			{
				CharTimer1 += Time.deltaTime;
				CharTime1 = Manager.stayTime - 1 - CharTimer1;
				charTimer1.value = CharTime1;
			}
		}

		if (Feel2)
		{
			if (IsTimer2)
			{
				charTimer2.maxValue = Manager.stayTime - 1;
				charTimer2.value = Manager.stayTime - 1;
				CharTimer2 = 0f;
				IsTimer2 = false;
			}
			if (timeFlow2)
			{
				CharTimer2 += Time.deltaTime;
				CharTime2 = Manager.stayTime - 1 - CharTimer2;
				charTimer2.value = CharTime2;
			}
		}

		if (Feel3)
		{
			if (IsTimer3)
			{
				charTimer3.maxValue = Manager.stayTime - 1;
				charTimer3.value = Manager.stayTime - 1;
				CharTimer3 = 0f;
				IsTimer3 = false;
			}
			if (timeFlow3)
			{
				CharTimer3 += Time.deltaTime;
				CharTime3 = Manager.stayTime - 1 - CharTimer3;
				charTimer3.value = CharTime3;
			}
		}

		if (randomSelect == 1)
		{
			character = char1;
			charFeel = "1";
		}
		else if (randomSelect == 2)
		{
			character = char2;
			charFeel = "2";
		}
		else if (randomSelect == 3)
		{
			character = char3;
			charFeel = "3";
		}
		else if (randomSelect == 4)
		{
			character = char4;
			charFeel = "4";
		}
		else if (randomSelect == 5)
		{
			character = char5;
			charFeel = "5";
		}
		else if (randomSelect == 6)
		{
			character = char6;
			charFeel = "6";
		}
		else if (randomSelect == 7)
		{
			character = char7;
			charFeel = "7";
		}
		else if (randomSelect == 8)
		{
			character = char8;
			charFeel = "8";
		}
		else
		{
			character = char9;
			charFeel = "9";
		}

		int foodSelect = Random.Range(1, 28);
		int foodSelect2 = Random.Range(1, 28);
		int foodSelect3 = Random.Range(1, 28);

		if (foodSelect == 1)
		{
			food = Food1;
			SetScale = "Big";
		}
		else if (foodSelect == 2)
		{
			food = Food2;
			SetScale = "Big";
		}
		else if (foodSelect == 3)
		{
			food = Food3;
			SetScale = "Big";
		}
		else if (foodSelect == 4)
		{
			food = Food4;
			SetScale = "Big";
		}
		else if (foodSelect == 5)
		{
			food = Food5;
			SetScale = "Big";
		}
		else if (foodSelect == 6)
		{
			food = Food6;
			SetScale = "Big";
		}
		else if (foodSelect == 7)
		{
			food = Food7;
			SetScale = "Big";
		}
		else if (foodSelect == 8)
		{
			food = Food8;
			SetScale = "Big";
		}
		else if (foodSelect == 9)
		{
			food = Food9;
			SetScale = "Big";
		}
		else if (foodSelect == 10)
		{
			food = Food10;
			SetScale = "Small";
		}
		else if (foodSelect == 11)
		{
			food = Food11;
			SetScale = "Small";
		}
		else if (foodSelect == 12)
		{
			food = Food12;
			SetScale = "Small";
		}
		else if (foodSelect == 13)
		{
			food = Food13;
			SetScale = "Small";
		}
		else if (foodSelect == 14)
		{
			food = Food14;
			SetScale = "Small";
		}
		else if (foodSelect == 15)
		{
			food = Food15;
			SetScale = "Small";
		}
		else if (foodSelect == 16)
		{
			food = Food16;
			SetScale = "Small";
		}
		else if (foodSelect == 17)
		{
			food = Food17;
			SetScale = "Small";
		}
		else if (foodSelect == 18)
		{
			food = Food18;
			SetScale = "Small";
		}
		else if (foodSelect == 19)
		{
			food = Food9;
			SetScale = "Mid";
		}
		else if (foodSelect == 20)
		{
			food = Food20;
			SetScale = "Mid";
		}
		else if (foodSelect == 21)
		{
			food = Food21;
			SetScale = "Mid";
		}
		else if (foodSelect == 22)
		{
			food = Food22;
			SetScale = "Mid";
		}
		else if (foodSelect == 23)
		{
			food = Food23;
			SetScale = "Mid";
		}
		else if (foodSelect == 24)
		{
			food = Food24;
			SetScale = "Mid";
		}
		else if (foodSelect == 25)
		{
			food = Food25;
			SetScale = "Mid";
		}
		else if (foodSelect == 26)
		{
			food = Food26;
			SetScale = "Mid";
		}
		else
		{
			food = Food27;
			SetScale = "Mid";
		}

		if(Manager.Day >= 10)
		{
			if (foodSelect2 == 1)
			{
				fooD2 = Food1;
				SetScale2 = "Big";
			}
			else if (foodSelect2 == 2)
			{
				fooD2 = Food2;
				SetScale2 = "Big";
			}
			else if (foodSelect2 == 3)
			{
				fooD2 = Food3;
				SetScale2 = "Big";
			}
			else if (foodSelect2 == 4)
			{
				fooD2 = Food4;
				SetScale2 = "Big";
			}
			else if (foodSelect2 == 5)
			{
				fooD2 = Food5;
				SetScale2 = "Big";
			}
			else if (foodSelect2 == 6)
			{
				fooD2 = Food6;
				SetScale2 = "Big";
			}
			else if (foodSelect2 == 7)
			{
				fooD2 = Food7;
				SetScale2 = "Big";
			}
			else if (foodSelect2 == 8)
			{
				fooD2 = Food8;
				SetScale2 = "Big";
			}
			else if (foodSelect2 == 9)
			{
				fooD2 = Food9;
				SetScale2 = "Big";
			}
			else if (foodSelect2 == 10)
			{
				fooD2 = Food10;
				SetScale2 = "Small";
			}
			else if (foodSelect2 == 11)
			{
				fooD2 = Food11;
				SetScale2 = "Small";
			}
			else if (foodSelect2 == 12)
			{
				fooD2 = Food12;
				SetScale2 = "Small";
			}
			else if (foodSelect2 == 13)
			{
				fooD2 = Food13;
				SetScale2 = "Small";
			}
			else if (foodSelect2 == 14)
			{
				fooD2 = Food14;
				SetScale2 = "Small";
			}
			else if (foodSelect2 == 15)
			{
				fooD2 = Food15;
				SetScale2 = "Small";
			}
			else if (foodSelect2 == 16)
			{
				fooD2 = Food16;
				SetScale2 = "Small";
			}
			else if (foodSelect2 == 17)
			{
				fooD2 = Food17;
				SetScale2 = "Small";
			}
			else if (foodSelect2 == 18)
			{
				fooD2 = Food18;
				SetScale2 = "Small";
			}
			else if (foodSelect2 == 19)
			{
				fooD2 = Food9;
				SetScale2 = "Mid";
			}
			else if (foodSelect2 == 20)
			{
				fooD2 = Food20;
				SetScale2 = "Mid";
			}
			else if (foodSelect2 == 21)
			{
				fooD2 = Food21;
				SetScale2 = "Mid";
			}
			else if (foodSelect2 == 22)
			{
				fooD2 = Food22;
				SetScale2 = "Mid";
			}
			else if (foodSelect2 == 23)
			{
				fooD2 = Food23;
				SetScale2 = "Mid";
			}
			else if (foodSelect2 == 24)
			{
				fooD2 = Food24;
				SetScale2 = "Mid";
			}
			else if (foodSelect2 == 25)
			{
				fooD2 = Food25;
				SetScale2 = "Mid";
			}
			else if (foodSelect2 == 26)
			{
				fooD2 = Food26;
				SetScale2 = "Mid";
			}
			else
			{
				fooD2 = Food27;
				SetScale2 = "Mid";
			}
		}

		if(Manager.Day >= 20)
		{
			if (foodSelect3 == 1)
			{
				fooD3 = Food1;
				SetScale3 = "Big";
			}
			else if (foodSelect3 == 2)
			{
				fooD3 = Food2;
				SetScale3 = "Big";
			}
			else if (foodSelect3 == 3)
			{
				fooD3 = Food3;
				SetScale3 = "Big";
			}
			else if (foodSelect3 == 4)
			{
				fooD3 = Food4;
				SetScale3 = "Big";
			}
			else if (foodSelect3 == 5)
			{
				fooD3 = Food5;
				SetScale3 = "Big";
			}
			else if (foodSelect3 == 6)
			{
				fooD3 = Food6;
				SetScale3 = "Big";
			}
			else if (foodSelect3 == 7)
			{
				fooD3 = Food7;
				SetScale3 = "Big";
			}
			else if (foodSelect3 == 8)
			{
				fooD3 = Food8;
				SetScale3 = "Big";
			}
			else if (foodSelect3 == 9)
			{
				fooD3 = Food9;
				SetScale3 = "Big";
			}
			else if (foodSelect3 == 10)
			{
				fooD3 = Food10;
				SetScale3 = "Small";
			}
			else if (foodSelect3 == 11)
			{
				fooD3 = Food11;
				SetScale3 = "Small";
			}
			else if (foodSelect3 == 12)
			{
				fooD3 = Food12;
				SetScale3 = "Small";
			}
			else if (foodSelect3 == 13)
			{
				fooD3 = Food13;
				SetScale3 = "Small";
			}
			else if (foodSelect3 == 14)
			{
				fooD3 = Food14;
				SetScale3 = "Small";
			}
			else if (foodSelect3 == 15)
			{
				fooD3 = Food15;
				SetScale3 = "Small";
			}
			else if (foodSelect3 == 16)
			{
				fooD3 = Food16;
				SetScale3 = "Small";
			}
			else if (foodSelect3 == 17)
			{
				fooD3 = Food17;
				SetScale3 = "Small";
			}
			else if (foodSelect3 == 18)
			{
				fooD3 = Food18;
				SetScale3 = "Small";
			}
			else if (foodSelect3 == 19)
			{
				fooD3 = Food9;
				SetScale3 = "Mid";
			}
			else if (foodSelect3 == 20)
			{
				fooD3 = Food20;
				SetScale3 = "Mid";
			}
			else if (foodSelect3 == 21)
			{
				fooD3 = Food21;
				SetScale3 = "Mid";
			}
			else if (foodSelect3 == 22)
			{
				fooD3 = Food22;
				SetScale3 = "Mid";
			}
			else if (foodSelect3 == 23)
			{
				fooD3 = Food23;
				SetScale3 = "Mid";
			}
			else if (foodSelect3 == 24)
			{
				fooD3 = Food24;
				SetScale3 = "Mid";
			}
			else if (foodSelect3 == 25)
			{
				fooD3 = Food25;
				SetScale3 = "Mid";
			}
			else if (foodSelect3 == 26)
			{
				fooD3 = Food26;
				SetScale3 = "Mid";
			}
			else
			{
				fooD3 = Food27;
				SetScale3 = "Mid";
			}
		}

		if (Manager.Day <= 30)
		{
			if (!food1)
			{
				food1 = Instantiate(delImg, LocFood1.transform.position, Quaternion.identity) as GameObject;
				food1.transform.parent = FoodManager;
				food1.transform.localScale = new Vector3(0f, 0f, 0f);
			}

			if (!food12)
			{
				food12 = Instantiate(delImg, LocFood12.transform.position, Quaternion.identity) as GameObject;
				food12.transform.parent = FoodManager;
				food12.transform.localScale = new Vector3(0f, 0f, 0f);
			}

			if (!food13)
			{
				food13 = Instantiate(delImg, LocFood13.transform.position, Quaternion.identity) as GameObject;
				food13.transform.parent = FoodManager;
				food13.transform.localScale = new Vector3(0f, 0f, 0f);
			}

			if (!food2)
			{
				food2 = Instantiate(delImg, LocFood2.transform.position, Quaternion.identity) as GameObject;
				food2.transform.parent = FoodManager;
				food2.transform.localScale = new Vector3(0f, 0f, 0f);
			}

			if (!food22)
			{
				food22 = Instantiate(delImg, LocFood22.transform.position, Quaternion.identity) as GameObject;
				food22.transform.parent = FoodManager;
				food22.transform.localScale = new Vector3(0f, 0f, 0f);
			}

			if (!food23)
			{
				food23 = Instantiate(delImg, LocFood23.transform.position, Quaternion.identity) as GameObject;
				food23.transform.parent = FoodManager;
				food23.transform.localScale = new Vector3(0f, 0f, 0f);
			}

			if (!food3)
			{
				food3 = Instantiate(delImg, LocFood3.transform.position, Quaternion.identity) as GameObject;
				food3.transform.parent = FoodManager;
				food3.transform.localScale = new Vector3(0f, 0f, 0f);
			}

			if (!food32)
			{
				food32 = Instantiate(delImg, LocFood32.transform.position, Quaternion.identity) as GameObject;
				food32.transform.parent = FoodManager;
				food32.transform.localScale = new Vector3(0f, 0f, 0f);
			}

			if (!food33)
			{
				food33 = Instantiate(delImg, LocFood33.transform.position, Quaternion.identity) as GameObject;
				food33.transform.parent = FoodManager;
				food33.transform.localScale = new Vector3(0f, 0f, 0f);
			}
			if (Manager.Day < 10) {
				if (!food1 && Feel1) { Destroy(food12); Destroy(food13); delete1 = true; }

				if (!food2 && Feel2) { Destroy(food22); Destroy(food23); delete2 = true; }

				if (!food3 && Feel3) { Destroy(food32); Destroy(food33); delete3 = true; }
			}

			if (Manager.Day < 20 && Manager.Day >= 10){
				if (food1.tag == "Untagged" && food12.tag == "Untagged" && Feel1) { Destroy(food1); Destroy(food12); Destroy(food13); delete1 = true; }

				if (food2.tag == "Untagged" && food22.tag == "Untagged" && Feel2) { Destroy(food2); Destroy(food22); Destroy(food23); delete2 = true; }

				if (food3.tag == "Untagged" && food32.tag == "Untagged" && Feel3) { Destroy(food3); Destroy(food32); Destroy(food33); delete3 = true; }
			}

			if (Manager.Day >= 20){
				if (food1.tag == "Untagged" && food12.tag == "Untagged" && food13.tag == "Untagged" && Feel1) { Destroy(food1); Destroy(food12); Destroy(food13); delete1 = true; }

				if (food2.tag == "Untagged" && food22.tag == "Untagged" && food13.tag == "Untagged" && Feel2) { Destroy(food2); Destroy(food22); Destroy(food23); delete2 = true; }

				if (food3.tag == "Untagged" && food32.tag == "Untagged" && food13.tag == "Untagged" && Feel3) { Destroy(food3); Destroy(food32); Destroy(food33); delete3 = true; }
			}
		}

		if (delete1)
		{
			if (cf1 == "1")
			{
				hchar11 = Instantiate(hchar1, LocChar1.transform.position, Quaternion.identity) as GameObject;
				Destroy(hchar11, 0.5f);
			}
			else if (cf1 == "2")
			{
				hchar11 = Instantiate(hchar2, LocChar1.transform.position, Quaternion.identity) as GameObject;
				Destroy(hchar11, 0.5f);
			}
			else if (cf1 == "3")
			{
				hchar11 = Instantiate(hchar3, LocChar1.transform.position, Quaternion.identity) as GameObject;
				Destroy(hchar11, 0.5f);
			}
			else if (cf1 == "4")
			{
				hchar11 = Instantiate(hchar4, LocChar1.transform.position, Quaternion.identity) as GameObject;
				Destroy(hchar11, 0.5f);
			}
			else if (cf1 == "5")
			{
				hchar11 = Instantiate(hchar5, LocChar1.transform.position, Quaternion.identity) as GameObject;
				Destroy(hchar11, 0.5f);
			}
			else if (cf1 == "6")
			{
				hchar11 = Instantiate(hchar6, LocChar1.transform.position, Quaternion.identity) as GameObject;
				Destroy(hchar11, 0.5f);
			}
			else if (cf1 == "7")
			{
				hchar11 = Instantiate(hchar7, LocChar1.transform.position, Quaternion.identity) as GameObject;
				Destroy(hchar11, 0.5f);
			}
			else if (cf1 == "8")
			{
				hchar11 = Instantiate(hchar8, LocChar1.transform.position, Quaternion.identity) as GameObject;
				Destroy(hchar11, 0.5f);
			}
			else
			{
				hchar11 = Instantiate(hchar9, LocChar1.transform.position, Quaternion.identity) as GameObject;
				Destroy(hchar11, 0.5f);
			}
			Destroy(Feel1);
			Destroy(Char1);
			charStay1 = 0f;
			CharProduce1 = true;
			hchar11.transform.parent = CharacterManager;
			hchar11.transform.localScale = new Vector3(3.05f, 3.85f, 1f);
			Destroy(hchar11, 0.5f);
			delete1 = false;
		}
		if (delete2)
		{
			if (cf2 == "1")
			{
				hchar22 = Instantiate(hchar1, LocChar2.transform.position, Quaternion.identity) as GameObject;
				Destroy(hchar22, 0.5f);
			}
			else if (cf2 == "2")
			{
				hchar22 = Instantiate(hchar2, LocChar2.transform.position, Quaternion.identity) as GameObject;
				Destroy(hchar22, 0.5f);
			}
			else if (cf2 == "3")
			{
				hchar22 = Instantiate(hchar3, LocChar2.transform.position, Quaternion.identity) as GameObject;
				Destroy(hchar22, 0.5f);
			}
			else if (cf2 == "4")
			{
				hchar22 = Instantiate(hchar4, LocChar2.transform.position, Quaternion.identity) as GameObject;
				Destroy(hchar22, 0.5f);
			}
			else if (cf2 == "5")
			{
				hchar22 = Instantiate(hchar5, LocChar2.transform.position, Quaternion.identity) as GameObject;
				Destroy(hchar22, 0.5f);
			}
			else if (cf2 == "6")
			{
				hchar22 = Instantiate(hchar6, LocChar2.transform.position, Quaternion.identity) as GameObject;
				Destroy(hchar22, 0.5f);
			}
			else if (cf2 == "7")
			{
				hchar22 = Instantiate(hchar7, LocChar2.transform.position, Quaternion.identity) as GameObject;
				Destroy(hchar22, 0.5f);
			}
			else if (cf2 == "8")
			{
				hchar22 = Instantiate(hchar8, LocChar2.transform.position, Quaternion.identity) as GameObject;
				Destroy(hchar22, 0.5f);
			}
			else
			{
				hchar22 = Instantiate(hchar9, LocChar2.transform.position, Quaternion.identity) as GameObject;
				Destroy(hchar22, 0.5f);
			}
			Destroy(Feel2);
			Destroy(Char2);
			charStay2 = 0f;
			CharProduce2 = true;
			hchar22.transform.parent = CharacterManager;
			hchar22.transform.localScale = new Vector3(3.05f, 3.85f, 1f);
			Destroy(hchar22, 0.5f);
			delete2 = false;
		}
		if (delete3)
		{
			if (cf3 == "1")
			{
				hchar33 = Instantiate(hchar1, LocChar3.transform.position, Quaternion.identity) as GameObject;
				Destroy(hchar33, 0.5f);
			}
			else if (cf3 == "2")
			{
				hchar33 = Instantiate(hchar2, LocChar3.transform.position, Quaternion.identity) as GameObject;
				Destroy(hchar33, 0.5f);
			}
			else if (cf3 == "3")
			{
				hchar33 = Instantiate(hchar3, LocChar3.transform.position, Quaternion.identity) as GameObject;
				Destroy(hchar33, 0.5f);
			}
			else if (cf3 == "4")
			{
				hchar33 = Instantiate(hchar4, LocChar3.transform.position, Quaternion.identity) as GameObject;
				Destroy(hchar33, 0.5f);
			}
			else if (cf3 == "5")
			{
				hchar33 = Instantiate(hchar5, LocChar3.transform.position, Quaternion.identity) as GameObject;
				Destroy(hchar33, 0.5f);
			}
			else if (cf3 == "6")
			{
				hchar33 = Instantiate(hchar6, LocChar3.transform.position, Quaternion.identity) as GameObject;
				Destroy(hchar33, 0.5f);
			}
			else if (cf3 == "7")
			{
				hchar33 = Instantiate(hchar7, LocChar3.transform.position, Quaternion.identity) as GameObject;
				Destroy(hchar33, 0.5f);
			}
			else if (cf3 == "8")
			{
				hchar33 = Instantiate(hchar8, LocChar3.transform.position, Quaternion.identity) as GameObject;
				Destroy(hchar33, 0.5f);
			}
			else
			{
				hchar33 = Instantiate(hchar9, LocChar3.transform.position, Quaternion.identity) as GameObject;
				Destroy(hchar33, 0.5f);
			}
			Destroy(Feel3);
			Destroy(Char3);
			charStay3 = 0f;
			CharProduce3 = true;
			hchar33.transform.parent = CharacterManager;
			hchar33.transform.localScale = new Vector3(3.05f, 3.85f, 1f);
			Destroy(hchar33, 0.5f);
			delete3 = false;
		}

		if (roundTime == 1)
		{
			if (IsOne)
			{
				cf1 = charFeel;
				Char1 = Instantiate(character, LocChar1.transform.position, Quaternion.identity) as GameObject;
				Char1.transform.parent = CharacterManager;
				Char1.transform.localScale = new Vector3(3.05f, 3.825f, 1f);
				timeFlow1 = true;
				IsOne = false;
			}
		}
		if (roundTime == 2)
		{
			if (Isone)
			{
				Feel1 = Instantiate(feeling1, LocFood12.transform.position, Quaternion.identity) as GameObject;
				Feel1.transform.parent = FoodManager;
				Feel1.transform.localScale = new Vector3(3.5f, 4f, 1f);

				oneOne = true;

				food1 = Instantiate(food, LocFood1.transform.position, Quaternion.identity) as GameObject;
				food1.transform.parent = FoodManager;
				if (SetScale == "Big")
				{
					food1.transform.localScale = new Vector3(0.75f, 0.8f, 1f);
				}
				else if (SetScale == "Mid")
				{
					food1.transform.localScale = new Vector3(0.65f, 0.69f, 1f);
				}
				else if (SetScale == "Small")
				{
					food1.transform.localScale = new Vector3(0.55f, 0.58f, 1f);
				}
				if (Manager.Day >= 10)
				{
					oneTwo = true;
					food12 = Instantiate(fooD2, LocFood12.transform.position, Quaternion.identity) as GameObject;
					food12.transform.parent = FoodManager;
					if (SetScale2 == "Big")
					{
						food12.transform.localScale = new Vector3(0.75f, 0.8f, 1f);
					}
					else if (SetScale2 == "Mid")
					{
						food12.transform.localScale = new Vector3(0.65f, 0.69f, 1f);
					}
					else if (SetScale2 == "Small")
					{
						food12.transform.localScale = new Vector3(0.55f, 0.58f, 1f);
					}
				}
				if (Manager.Day >= 20)
				{
					oneThree = true;
					food13 = Instantiate(fooD3, LocFood13.transform.position, Quaternion.identity) as GameObject;
					food13.transform.parent = FoodManager;
					if (SetScale3 == "Big")
					{
						food13.transform.localScale = new Vector3(0.75f, 0.8f, 1f);
					}
					else if (SetScale3 == "Mid")
					{
						food13.transform.localScale = new Vector3(0.65f, 0.69f, 1f);
					}
					else if (SetScale3 == "Small")
					{
						food13.transform.localScale = new Vector3(0.55f, 0.58f, 1f);
					}
				}
					Isone = false;
			}
		}

		if (roundTime == 5)
		{
			if (IsTwo)
			{
				cf2 = charFeel;
				Char2 = Instantiate(character, LocChar2.transform.position, Quaternion.identity) as GameObject;
				Char2.transform.parent = CharacterManager;
				Char2.transform.localScale = new Vector3(3.05f, 3.825f, 1f);
				timeFlow2 = true;
				IsTwo = false;
			}
		}
		if(roundTime == 6)
		{
			if (Istwo)
			{
				twoOne = true;

				Feel2 = Instantiate(feeling1, LocFood22.transform.position, Quaternion.identity) as GameObject;
				Feel2.transform.parent = FoodManager;
				Feel2.transform.localScale = new Vector3(3.5f, 4f, 1f);

				food2 = Instantiate(food, LocFood2.transform.position, Quaternion.identity) as GameObject;
				food2.transform.parent = FoodManager;
				if (SetScale == "Big")
				{
					food2.transform.localScale = new Vector3(0.75f, 0.8f, 1f);
				}
				else if (SetScale == "Mid")
				{
					food2.transform.localScale = new Vector3(0.65f, 0.69f, 1f);
				}
				else if (SetScale == "Small")
				{
					food2.transform.localScale = new Vector3(0.55f, 0.58f, 1f);
				}
				if (Manager.Day >= 10)
				{
					twoTwo = true;

					food22 = Instantiate(fooD2, LocFood22.transform.position, Quaternion.identity) as GameObject;
					food22.transform.parent = FoodManager;
					if (SetScale2 == "Big")
					{
						food22.transform.localScale = new Vector3(0.75f, 0.8f, 1f);
					}
					else if (SetScale2 == "Mid")
					{
						food22.transform.localScale = new Vector3(0.65f, 0.69f, 1f);
					}
					else if (SetScale2 == "Small")
					{
						food22.transform.localScale = new Vector3(0.55f, 0.58f, 1f);
					}
				}
				if (Manager.Day >= 20)
				{
					twoThree = true;

					food23 = Instantiate(fooD3, LocFood23.transform.position, Quaternion.identity) as GameObject;
					food23.transform.parent = FoodManager;
					if (SetScale3 == "Big")
					{
						food23.transform.localScale = new Vector3(0.75f, 0.8f, 1f);
					}
					else if (SetScale3 == "Mid")
					{
						food23.transform.localScale = new Vector3(0.65f, 0.69f, 1f);
					}
					else if (SetScale3 == "Small")
					{
						food23.transform.localScale = new Vector3(0.55f, 0.58f, 1f);
					}
				}
					Istwo = false;
			}
		}

		if (roundTime == 10)
		{
			if (IsThree)
			{
				cf3 = charFeel;
				Char3 = Instantiate(character, LocChar3.transform.position, Quaternion.identity) as GameObject;
				Char3.transform.parent = CharacterManager;
				Char3.transform.localScale = new Vector3(3.05f, 3.825f, 1f);
				timeFlow3 = true;
				IsThree = false;
			}
		}
		if(roundTime == 11)
		{
			if (Isthree)
			{
				threeOne = true;

				Feel3 = Instantiate(feeling1, LocFood32.transform.position, Quaternion.identity) as GameObject;
				Feel3.transform.parent = FoodManager;
				Feel3.transform.localScale = new Vector3(3.5f, 4f, 1f);

				food3 = Instantiate(food, LocFood3.transform.position, Quaternion.identity) as GameObject;
				food3.transform.parent = FoodManager;
				if (SetScale == "Big")
				{
					food3.transform.localScale = new Vector3(0.75f, 0.8f, 1f);
				}
				else if (SetScale == "Mid")
				{
					food3.transform.localScale = new Vector3(0.65f, 0.69f, 1f);
				}
				else if (SetScale == "Small")
				{
					food3.transform.localScale = new Vector3(0.55f, 0.58f, 1f);
				}
					if (Manager.Day >= 10)
					{
					threeTwo = true;

						food32 = Instantiate(fooD2, LocFood32.transform.position, Quaternion.identity) as GameObject;
						food32.transform.parent = FoodManager;
						if (SetScale2 == "Big")
						{
							food32.transform.localScale = new Vector3(0.75f, 0.8f, 1f);
						}
						else if (SetScale2 == "Mid")
						{
							food32.transform.localScale = new Vector3(0.65f, 0.69f, 1f);
						}
						else if (SetScale2 == "Small")
						{
							food32.transform.localScale = new Vector3(0.55f, 0.58f, 1f);
						}
					}
					if (Manager.Day >= 20)
					{
					threeThree = true;

						food33 = Instantiate(fooD3, LocFood33.transform.position, Quaternion.identity) as GameObject;
						food33.transform.parent = FoodManager;
						if (SetScale3 == "Big")
						{
							food33.transform.localScale = new Vector3(0.75f, 0.8f, 1f);
						}
						else if (SetScale3 == "Mid")
						{
							food33.transform.localScale = new Vector3(0.65f, 0.69f, 1f);
						}
						else if (SetScale3 == "Small")
						{
							food33.transform.localScale = new Vector3(0.55f, 0.58f, 1f);
						}
					}
						Isthree = false;
			}
		}



		if (timeFlow1)
		{
			charStay1 += Time.deltaTime;

			if (charStay1 >= Manager.stayTime)
			{
				if(charFeeling1)
				{
					oneOne = false;
					oneTwo = false;
					oneThree = false;
					Destroy(Feel1);
					Destroy(food1);
					Destroy(food12);
					Destroy(food13);
					if (Char1)
					{
						Destroy(Char1);
						if (cf1 == "1")
						{
							makeCharFeel(charFeeling, char11, LocChar1, CharacterManager);
						}
						else if (cf1 == "2")
						{
							makeCharFeel(charFeeling, char12, LocChar1, CharacterManager);
						}
						else if (cf1 == "3")
						{
							makeCharFeel(charFeeling, char13, LocChar1, CharacterManager);
						}
						else if (cf1 == "4")
						{
							makeCharFeel(charFeeling, char14, LocChar1, CharacterManager);
						}
						else if (cf1 == "5")
						{
							makeCharFeel(charFeeling, char15, LocChar1, CharacterManager);
						}
						else if (cf1 == "6")
						{
							makeCharFeel(charFeeling, char16, LocChar1, CharacterManager);
						}
						else if (cf1 == "7")
						{
							makeCharFeel(charFeeling, char17, LocChar1, CharacterManager);
						}
						else if (cf1 == "8")
						{
							makeCharFeel(charFeeling, char18, LocChar1, CharacterManager);
						}
						else
						{
							makeCharFeel(charFeeling, char19, LocChar1, CharacterManager);
						}
					}
					charFeeling1 = false;
				}
			}

			if (charStay1 >= Manager.stayTime + 1)
			{
				if (CharProduce1)
				{
					cf1 = charFeel;
					Char1 = Instantiate(character, LocChar1.transform.position, Quaternion.identity) as GameObject;
					Char1.transform.parent = CharacterManager;
					Char1.transform.localScale = new Vector3(3.05f, 3.825f, 1f);
					CharProduce1 = false;
				}
			}

			if (charStay1 >= Manager.stayTime + 2)
			{
				oneOne = true;

				Feel1 = Instantiate(feeling1, LocFood12.transform.position, Quaternion.identity) as GameObject;
				Feel1.transform.parent = FoodManager;
				Feel1.transform.localScale = new Vector3(3.5f, 4f, 1f);

				food1 = Instantiate(food, LocFood1.transform.position, Quaternion.identity) as GameObject;
				food1.transform.parent = FoodManager;
				if (SetScale == "Big")
				{
					food1.transform.localScale = new Vector3(0.75f, 0.8f, 1f);
				}
				else if (SetScale == "Mid")
				{
					food1.transform.localScale = new Vector3(0.65f, 0.69f, 1f);
				}
				else if (SetScale == "Small")
				{
					food1.transform.localScale = new Vector3(0.55f, 0.58f, 1f);
				}
				if (Manager.Day >= 10)
				{
					oneTwo = true;
					food12 = Instantiate(fooD2, LocFood12.transform.position, Quaternion.identity) as GameObject;
					food12.transform.parent = FoodManager;
					if (SetScale2 == "Big")
					{
						food12.transform.localScale = new Vector3(0.75f, 0.8f, 1f);
					}
					else if (SetScale2 == "Mid")
					{
						food12.transform.localScale = new Vector3(0.65f, 0.69f, 1f);
					}
					else if (SetScale2 == "Small")
					{
						food12.transform.localScale = new Vector3(0.55f, 0.58f, 1f);
					}
				}
				if (Manager.Day >= 20)
				{
					oneThree = true;
					food13 = Instantiate(fooD3, LocFood13.transform.position, Quaternion.identity) as GameObject;
					food13.transform.parent = FoodManager;
					if (SetScale3 == "Big")
					{
						food13.transform.localScale = new Vector3(0.75f, 0.8f, 1f);
					}
					else if (SetScale3 == "Mid")
					{
						food13.transform.localScale = new Vector3(0.65f, 0.69f, 1f);
					}
					else if (SetScale3 == "Small")
					{
						food13.transform.localScale = new Vector3(0.55f, 0.58f, 1f);
					}
				}
				charStay1 = 0;
				CharProduce1 = true;
				IsTimer1 = true;
				charFeeling1 = true;
			}
		}

		if (timeFlow2)
		{
			charStay2 += Time.deltaTime;

			if (charStay2 >= Manager.stayTime)
			{
				if (charFeeling2)
				{
					twoOne = false;
					twoTwo = false;
					twoThree = false;
					Destroy(Feel2);
					Destroy(food2);
					Destroy(food22);
					Destroy(food23);
					if (Char2)
					{
						Destroy(Char2);
						if (cf2 == "1")
						{
							makeCharFeel(charFeeling, char11, LocChar2, CharacterManager);
						}
						else if (cf2 == "2")
						{
							makeCharFeel(charFeeling, char12, LocChar2, CharacterManager);
						}
						else if (cf2 == "3")
						{
							makeCharFeel(charFeeling, char13, LocChar2, CharacterManager);
						}
						else if (cf2 == "4")
						{
							makeCharFeel(charFeeling, char14, LocChar2, CharacterManager);
						}
						else if (cf2 == "5")
						{
							makeCharFeel(charFeeling, char15, LocChar2, CharacterManager);
						}
						else if (cf2 == "6")
						{
							makeCharFeel(charFeeling, char16, LocChar2, CharacterManager);
						}
						else if (cf2 == "7")
						{
							makeCharFeel(charFeeling, char17, LocChar2, CharacterManager);
						}
						else if (cf2 == "8")
						{
							makeCharFeel(charFeeling, char18, LocChar2, CharacterManager);
						}
						else
						{
							makeCharFeel(charFeeling, char19, LocChar2, CharacterManager);
						}
					}
					charFeeling2 = false;
				}
			}

			if (charStay2 >= Manager.stayTime + 1)
				if (CharProduce2)
				{
					cf2 = charFeel;
					Char2 = Instantiate(character, LocChar2.transform.position, Quaternion.identity) as GameObject;
					Char2.transform.parent = CharacterManager;
					Char2.transform.localScale = new Vector3(3.05f, 3.825f, 1f);
					CharProduce2 = false;
				}

			if (charStay2 >= Manager.stayTime + 2)
			{
				twoOne = true;
				Feel2 = Instantiate(feeling1, LocFood22.transform.position, Quaternion.identity) as GameObject;
				Feel2.transform.parent = FoodManager;
				Feel2.transform.localScale = new Vector3(3.5f, 4f, 1f);

				food2 = Instantiate(food, LocFood2.transform.position, Quaternion.identity) as GameObject;
				food2.transform.parent = FoodManager;
				if (SetScale == "Big")
				{
					food2.transform.localScale = new Vector3(0.75f, 0.8f, 1f);
				}
				else if (SetScale == "Mid")
				{
					food2.transform.localScale = new Vector3(0.65f, 0.69f, 1f);
				}
				else if (SetScale == "Small")
				{
					food2.transform.localScale = new Vector3(0.55f, 0.58f, 1f);
				}
				if(Manager.Day >=10)
				{
					twoTwo = true;
					food22 = Instantiate(fooD2, LocFood22.transform.position, Quaternion.identity) as GameObject;
					food22.transform.parent = FoodManager;
					if (SetScale2 == "Big")
					{
						food22.transform.localScale = new Vector3(0.75f, 0.8f, 1f);
					}
					else if (SetScale2 == "Mid")
					{
						food22.transform.localScale = new Vector3(0.65f, 0.69f, 1f);
					}
					else if (SetScale2 == "Small")
					{
						food22.transform.localScale = new Vector3(0.55f, 0.58f, 1f);
					}
				}
				if(Manager.Day >= 20)
				{
					twoThree = true;
					food23 = Instantiate(fooD3, LocFood23.transform.position, Quaternion.identity) as GameObject;
					food23.transform.parent = FoodManager;
					if (SetScale3 == "Big")
					{
						food23.transform.localScale = new Vector3(0.75f, 0.8f, 1f);
					}
					else if (SetScale3 == "Mid")
					{
						food23.transform.localScale = new Vector3(0.65f, 0.69f, 1f);
					}
					else if (SetScale3 == "Small")
					{
						food23.transform.localScale = new Vector3(0.55f, 0.58f, 1f);
					}
				}
				charStay2 = 0;
				CharProduce2 = true;
				IsTimer2 = true;
				charFeeling2 = true;
			}
		}

		if (timeFlow3)
		{
			charStay3 += Time.deltaTime;

			if (charStay3 >= Manager.stayTime)
			{
				threeOne = false;
				threeTwo = false;
				threeThree = false;
				if (charFeeling3)
				{
					Destroy(Feel3);
					Destroy(food3);
					Destroy(food32);
					Destroy(food33);
					if (Char3)
					{
						Destroy(Char3);
						if (cf3 == "1")
						{
							makeCharFeel(charFeeling, char11, LocChar3, CharacterManager);
						}
						else if (cf3 == "2")
						{
							makeCharFeel(charFeeling, char12, LocChar3, CharacterManager);
						}
						else if (cf3 == "3")
						{
							makeCharFeel(charFeeling, char13, LocChar3, CharacterManager);
						}
						else if (cf3 == "4")
						{
							makeCharFeel(charFeeling, char14, LocChar3, CharacterManager);
						}
						else if (cf3 == "5")
						{
							makeCharFeel(charFeeling, char15, LocChar3, CharacterManager);
						}
						else if (cf3 == "6")
						{
							makeCharFeel(charFeeling, char16, LocChar3, CharacterManager);
						}
						else if (cf3 == "7")
						{
							makeCharFeel(charFeeling, char17, LocChar3, CharacterManager);
						}
						else if (cf3 == "8")
						{
							makeCharFeel(charFeeling, char18, LocChar3, CharacterManager);
						}
						else
						{
							makeCharFeel(charFeeling, char19, LocChar3, CharacterManager);
						}
					}
					charFeeling3 = false;
				}
			}

			if (charStay3 >= Manager.stayTime + 1)
			{
				if (CharProduce3)
				{
					cf3 = charFeel;
					Char3 = Instantiate(character, LocChar3.transform.position, Quaternion.identity) as GameObject;
					Char3.transform.parent = CharacterManager;
					Char3.transform.localScale = new Vector3(3.05f, 3.825f, 1f);
					CharProduce3 = false;
				}
			}

			if (charStay3 >= Manager.stayTime + 2)
			{
				threeOne = true;
				Feel3 = Instantiate(feeling1, LocFood32.transform.position, Quaternion.identity) as GameObject;
				Feel3.transform.parent = FoodManager;
				Feel3.transform.localScale = new Vector3(3.5f, 4f, 1f);

				food3 = Instantiate(food, LocFood3.transform.position, Quaternion.identity) as GameObject;
				food3.transform.parent = FoodManager;
				if (SetScale == "Big")
				{
					food3.transform.localScale = new Vector3(0.75f, 0.8f, 1f);
				}
				else if (SetScale == "Mid")
				{
					food3.transform.localScale = new Vector3(0.65f, 0.69f, 1f);
				}
				else if (SetScale == "Small")
				{
					food3.transform.localScale = new Vector3(0.55f, 0.58f, 1f);
				}
				if(Manager.Day >=10)
				{
					threeTwo = true;
					food32 = Instantiate(fooD2, LocFood32.transform.position, Quaternion.identity) as GameObject;
					food32.transform.parent = FoodManager;
					if (SetScale2 == "Big")
					{
						food32.transform.localScale = new Vector3(0.75f, 0.8f, 1f);
					}
					else if (SetScale2 == "Mid")
					{
						food32.transform.localScale = new Vector3(0.65f, 0.69f, 1f);
					}
					else if (SetScale2 == "Small")
					{
						food32.transform.localScale = new Vector3(0.55f, 0.58f, 1f);
					}
				}
				if(Manager.Day >= 20)
				{
					threeThree = true;
					food33 = Instantiate(fooD3, LocFood33.transform.position, Quaternion.identity) as GameObject;
					food33.transform.parent = FoodManager;
					if (SetScale3 == "Big")
					{
						food33.transform.localScale = new Vector3(0.75f, 0.8f, 1f);
					}
					else if (SetScale3 == "Mid")
					{
						food33.transform.localScale = new Vector3(0.65f, 0.69f, 1f);
					}
					else if (SetScale3 == "Small")
					{
						food33.transform.localScale = new Vector3(0.55f, 0.58f, 1f);
					}
				}
				charStay3 = 0;
				CharProduce3 = true;
				IsTimer3 = true;
				charFeeling3 = true;
			}
		}
		if(food1.tag == "Untagged" && oneOne)
		{
			oneOne = false;
			makeCoin(coin, coinImg, LocChar1, coinBox);
		}

		if(food12.tag == "Untagged" && oneTwo)
		{
			oneTwo = false;
			makeCoin(coin, coinImg, LocChar1, coinBox);
		}

		if (food13.tag == "Untagged" && oneThree)
		{
			oneThree = false;
			makeCoin(coin, coinImg, LocChar1, coinBox);
		}

		if (food2.tag == "Untagged" && twoOne)
		{
			twoOne = false;
			makeCoin(coin, coinImg, LocChar2, coinBox);
		}

		if (food22.tag == "Untagged" && twoTwo)
		{
			twoTwo = false;
			makeCoin(coin, coinImg, LocChar2, coinBox);
		}

		if (food23.tag == "Untagged" && twoThree)
		{
			twoThree = false;
			makeCoin(coin, coinImg, LocChar2, coinBox);
		}
		if (food3.tag == "Untagged" && threeOne)
		{
			threeOne = false;
			makeCoin(coin, coinImg, LocChar3, coinBox);
		}

		if (food32.tag == "Untagged" && threeTwo)
		{
			threeTwo = false;
			makeCoin(coin, coinImg, LocChar3, coinBox);
		}

		if (food33.tag == "Untagged" && threeThree)
		{
			threeThree = false;
			makeCoin(coin, coinImg, LocChar3, coinBox);
		}

		if (limitTimer && roundTime == Manager.playTime - 10)
		{
			limitTimer = false;
			GameObject redTimer = Instantiate(RedTimer, nextDayBGLoc, Quaternion.identity) as GameObject;
			redTimer.transform.localScale = new Vector2(1, 1);
			redTimer.transform.parent = RT;
		}

		if (roundTime == Manager.playTime)
		{
			if (Manager.Day != 30)
			{
				if (IsEnd == true)
				{
					Destroy(Char1);
					Destroy(Char2);
					Destroy(Char3);
					Destroy(food1);
					Destroy(food2);
					Destroy(food3);
					Destroy(food12);
					Destroy(food22);
					Destroy(food12);
					Destroy(food23);
					Destroy(food33);
					Destroy(food33);
					Destroy(Feel1);
					Destroy(Feel2);
					Destroy(Feel3);

					timeFlow1 = false;
					timeFlow2 = false;
					timeFlow3 = false;

					SceneManager.LoadScene("End");
				}
			}

			else
			{
				if (IsEnd == true)
				{
					Destroy(Char1);
					Destroy(Char2);
					Destroy(Char3);
					Destroy(food1);
					Destroy(food2);
					Destroy(food3);
					Destroy(food12);
					Destroy(food22);
					Destroy(food12);
					Destroy(food23);
					Destroy(food33);
					Destroy(food33);
					Destroy(Feel1);
					Destroy(Feel2);
					Destroy(Feel3);

					timeFlow1 = false;
					timeFlow2 = false;
					timeFlow3 = false;

					if (Manager.money < 50000)
					{
						SceneManager.LoadScene("Ending_1");
						Achieve.achi2 = true;
					}

					//노말 엔딩
					else if (50000 <= Manager.money)
					{
						SceneManager.LoadScene("Ending_2");
						Achieve.achi3 = true;
					}

					//영업의 신 엔딩
					else if (1000000 < Manager.money)
					{
						SceneManager.LoadScene("Ending_3");
						Achieve.achi4 = true;
					}
				}
			}
		}
	}
}