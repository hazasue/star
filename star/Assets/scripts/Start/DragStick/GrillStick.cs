using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrillStick : MonoBehaviour
{

	public GameObject Stick1;
	public GameObject Stick2;
	public GameObject Stick3;

	public GameObject CountStick1;
	public GameObject CountStick2;
	public GameObject RefillStick;

	public static GameObject stick1;
	public static GameObject stick2;
	public static GameObject stick3;

	public static Vector2 StartPos1;
	public static Vector2 StartPos2;
	public static Vector2 StartPos3;

	public static Transform Grill;
	

	public static Transform StickBox;
	Vector2 StickPos;
	// Start is called before the first frame update
	void Start()
    {

		StickPos = transform.position;

		Grill = GameObject.Find("Grill").GetComponent<Transform>();
		StickBox = GameObject.Find("StickBox").GetComponent<Transform>();

		if (gameObject.tag == "StickCount1")
		{
			StartPos1 = transform.position;
		}
		else if (gameObject.tag == "StickCount2")
		{
			StartPos2 = transform.position;
		}
		else if (gameObject.tag == "StickCount3")
		{
			StartPos3 = transform.position;
		}

	}

    // Update is called once per frame
    void Update()
    {

    }

	public void ClickStick1()
	{
		if (!finishGrill1.stick && !stick1)
		{
			stick1 = Instantiate(Stick1, StickLocation1.StickPos1, Quaternion.identity) as GameObject;
			stick1.transform.parent = Grill;
			stick1.transform.localScale = new Vector3(0.7f, 1f, 1f);

			if (Manager.STICK1 == 3)
			{
				Destroy(gameObject);
				GameObject Food3 = Instantiate(CountStick2, StickPos, Quaternion.identity) as GameObject;
				Food3.transform.parent = StickBox;
				Food3.transform.localScale = new Vector3(1.7375f, 0.48f, 1f);
			}
			else if (Manager.STICK1 == 2)
			{
				Destroy(gameObject);
				GameObject Food2 = Instantiate(CountStick1, StickPos, Quaternion.identity) as GameObject;
				Food2.transform.parent = StickBox;
				Food2.transform.localScale = new Vector3(1.7375f, 0.48f, 1f);
			}
			else if (Manager.STICK1 == 1)
			{
				Destroy(gameObject);
				GameObject Food1 = Instantiate(RefillStick, StickPos, Quaternion.identity) as GameObject;
				Food1.transform.parent = StickBox;
				Food1.transform.localScale = new Vector3(1.7375f, 0.48f, 1f);
			}
			Manager.STICK1 -= 1;
		}
	}

	public void ClickStick2()
	{
		if (!finishGrill2.stick && !stick2)
		{
			stick2 = Instantiate(Stick2, StickLocation2.StickPos2, Quaternion.identity) as GameObject;
			stick2.transform.parent = Grill;
			stick2.transform.localScale = new Vector3(0.7f, 1f, 1f);

			if (Manager.STICK2 == 3)
			{
				Destroy(gameObject);
				GameObject Food3 = Instantiate(CountStick2, StickPos, Quaternion.identity) as GameObject;
				Food3.transform.parent = StickBox;
				Food3.transform.localScale = new Vector3(1f, 0.825f, 1f);
			}
			else if (Manager.STICK2 == 2)
			{
				Destroy(gameObject);
				GameObject Food2 = Instantiate(CountStick1, StickPos, Quaternion.identity) as GameObject;
				Food2.transform.parent = StickBox;
				Food2.transform.localScale = new Vector3(1f, 0.825f, 1f);
			}
			else if (Manager.STICK2 == 1)
			{
				Destroy(gameObject);
				GameObject Food1 = Instantiate(RefillStick, StickPos, Quaternion.identity) as GameObject;
				Food1.transform.parent = StickBox;
				Food1.transform.localScale = new Vector3(1f, 0.825f, 1f);
			}
			Manager.STICK2 -= 1;
		}
	}

	public void ClickStick3()
	{
		if (!finishGrill3.stick && !stick3)
		{
			stick3 = Instantiate(Stick3, StickLocation3.StickPos3, Quaternion.identity) as GameObject;
			stick3.transform.parent = Grill;
			stick3.transform.localScale = new Vector3(0.7f, 1f, 1f);

			if (Manager.STICK3 == 3)
			{
				Destroy(gameObject);
				GameObject Food3 = Instantiate(CountStick2, StickPos, Quaternion.identity) as GameObject;
				Food3.transform.parent = StickBox;
				Food3.transform.localScale = new Vector3(1f, 0.825f, 1f);
			}
			else if (Manager.STICK3 == 2)
			{
				Destroy(gameObject);
				GameObject Food2 = Instantiate(CountStick1, StickPos, Quaternion.identity) as GameObject;
				Food2.transform.parent = StickBox;
				Food2.transform.localScale = new Vector3(1f, 0.825f, 1f);
			}
			else if (Manager.STICK3 == 1)
			{
				Destroy(gameObject);
				GameObject Food1 = Instantiate(RefillStick, StickPos, Quaternion.identity) as GameObject;
				Food1.transform.parent = StickBox;
				Food1.transform.localScale = new Vector3(1f, 0.825f, 1f);
			}
			Manager.STICK3 -= 1;

		}
	}
}
