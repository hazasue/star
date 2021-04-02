using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RefillYellowRice : MonoBehaviour
{

	public GameObject RefillBut;
	float Refilltime;

	public GameObject RefillTimer;
	bool refillTime;

	bool refill;
	// Start is called before the first frame update
	void Start()
	{
		refillTime = true;
		refill = false;
	}

	// Update is called once per frame
	void Update()
	{
		if (refill)
		{
			if (refillTime)
			{
				GameObject refillTimer = Instantiate(RefillTimer, DragRiceYellow.StartPos, Quaternion.identity) as GameObject;
				refillTimer.transform.parent = DragRiceYellow.BasicFood;
				refillTimer.transform.localScale = new Vector2(0.5f, 0.5f);

				Destroy(refillTimer, 2f);
				refillTime = false;
			}

			Refilltime += Time.deltaTime;
			if (Refilltime >= Manager.RiceRefillTime)
			{
				Destroy(gameObject);
				GameObject RefillButton = Instantiate(RefillBut, DragRiceYellow.StartPos, Quaternion.identity) as GameObject;
				RefillButton.transform.parent = DragRiceYellow.BasicFood;
				RefillButton.transform.localScale = new Vector3(1.430166f, 0.89175f, 1f);

				Manager.YellowRice = 3;
				Refilltime = 0f;
				refill = false;
			}
		}
	}

	public void refillYellowRice()
	{
		refill = true;
	}
}
