using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishGrill2 : MonoBehaviour
{

	public GameObject Stick2;
	public static GameObject stick;

	float time;

	// Start is called before the first frame update
	void Start()
	{
		time = 0;
	}

	// Update is called once per frame
	void Update()
	{
		time += Time.deltaTime;

		if (time >= 1)
		{
			Destroy(gameObject);
			stick = Instantiate(Stick2, StickLocation2.StickPos2, Quaternion.identity) as GameObject;
			stick.transform.parent = GrillStick.Grill;
			stick.transform.localScale = new Vector3(0.7f, 1f, 1f);
		}
	}
}
