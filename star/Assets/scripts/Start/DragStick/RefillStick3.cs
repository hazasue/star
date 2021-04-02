using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefillStick3 : MonoBehaviour
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
				GameObject refillTimer = Instantiate(RefillTimer, GrillStick.StartPos3, Quaternion.identity) as GameObject;
				refillTimer.transform.parent = DragRiceRed.BasicFood;
				refillTimer.transform.localScale = new Vector2(0.5f, 0.5f);

				Destroy(refillTimer, 2f);
				refillTime = false;
			}

			Refilltime += Time.deltaTime;
			if (Refilltime >= Manager.StickRefillTime)
			{
				Destroy(gameObject);
				GameObject RefillButton = Instantiate(RefillBut, GrillStick.StartPos3, Quaternion.identity) as GameObject;
				RefillButton.transform.parent = DragRiceRed.BasicFood;
				RefillButton.transform.localScale = new Vector3(1f, 0.825f, 1f);
				Manager.STICK3 = 3;
				Refilltime = 0f;
				refill = false;
			}
		}
	}

	public void refillStick3()
	{
		refill = true;
	}
}
