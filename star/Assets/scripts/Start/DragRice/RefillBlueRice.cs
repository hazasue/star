using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RefillBlueRice : MonoBehaviour
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
				GameObject refillTimer = Instantiate(RefillTimer, DragRiceBlue.StartPos, Quaternion.identity) as GameObject;
				refillTimer.transform.parent = DragRiceBlue.BasicFood;
				refillTimer.transform.localScale = new Vector2(0.5f, 0.5f);

				Destroy(refillTimer, 2f);
				refillTime = false;
			}

			Refilltime += Time.deltaTime;
			if (Refilltime >= Manager.RiceRefillTime)
			{
				Destroy(gameObject);
				GameObject RefillButton = Instantiate(RefillBut, DragRiceBlue.StartPos, Quaternion.identity) as GameObject;
				RefillButton.transform.parent = DragRiceBlue.BasicFood;
				RefillButton.transform.localScale = new Vector3(1.424812f, 1.099322f, 1f);
				Manager.BlueRice = 3;
				Refilltime = 0f;
				refill = false;
			}
		}
	}

	public void refillBlueRice()
	{
		refill = true;
	}
}
