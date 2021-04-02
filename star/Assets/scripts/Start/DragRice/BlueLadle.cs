using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BlueLadle : MonoBehaviour
{
	// Start is called before the first frame update


	Vector2 StartLoc;

	public GameObject CountFood2;
	public GameObject CountFood1;
	public GameObject RefillFood;

	public GameObject ladle;
	GameObject Ladle;

	GameObject Food1;
	GameObject Food2;
	GameObject Food3;


	public GameObject selectedFood;
	public GameObject selectedFoodS;
	public GameObject selectedFoodM;

	Transform Parent;
	public static Transform BasicFood;
	void Start()
	{
		StartLoc = DragRiceBlue.StartPos;
		Parent = GameObject.Find("OrderFood").GetComponent<Transform>();
		BasicFood = GameObject.Find("BasicFood").GetComponent<Transform>();
	}

	// Update is called once per frame
	void Update()
	{

	}

	public void OnTriggerExit2D(Collider2D collider)
	{
		if (DragRiceBlue.IsDrag == false)
		{
			if (collider.tag == "cup")
			{
				Destroy(GameObject.FindWithTag("cup"));
				GameObject Cup = Instantiate(selectedFood, DrawLocation.BarPos, Quaternion.identity) as GameObject;
				Cup.transform.parent = Parent;
				Cup.transform.localScale = new Vector3(1.5f, 1.6f, 1f);

				

				if (Manager.BlueRice == 3)
				{
					Destroy(GameObject.FindWithTag("BlueCount"));
					Food3 = Instantiate(CountFood2, StartLoc, Quaternion.identity) as GameObject;
					Food3.transform.parent = BasicFood;
					Food3.transform.localScale = new Vector3(1.424812f, 1.099322f, 1f);

				}
				else if (Manager.BlueRice == 2)
				{
					Destroy(GameObject.FindWithTag("BlueCount"));
					Food2 = Instantiate(CountFood1, StartLoc, Quaternion.identity) as GameObject;
					Food2.transform.parent = BasicFood;
					Food2.transform.localScale = new Vector3(1.424812f, 1.099322f, 1f);
				}
				else if (Manager.BlueRice == 1)
				{
					Destroy(GameObject.FindWithTag("BlueCount"));
					Food1 = Instantiate(RefillFood, StartLoc, Quaternion.identity) as GameObject;
					Food1.transform.parent = BasicFood;
					Food1.transform.localScale = new Vector3(1.424812f, 1.099322f, 1f);
				}
				Manager.BlueRice -= 1;
				
				
			}

			if (collider.tag == "cupS")
			{
				Destroy(GameObject.FindWithTag("cupS"));
				GameObject Cup = Instantiate(selectedFoodS, DrawLocation.BarPos, Quaternion.identity) as GameObject;
				Cup.transform.parent = Parent;
				Cup.transform.localScale = new Vector3(0.9f, 1.2f, 1f);


				if (Manager.BlueRice == 3)
				{
					Destroy(GameObject.FindWithTag("BlueCount"));
					Food3 = Instantiate(CountFood2, StartLoc, Quaternion.identity) as GameObject;
					Food3.transform.parent = BasicFood;
					Food3.transform.localScale = new Vector3(1.424812f, 1.099322f, 1f);
				}
				else if (Manager.BlueRice == 2)
				{
					Destroy(GameObject.FindWithTag("BlueCount"));
					Food2 = Instantiate(CountFood1, StartLoc, Quaternion.identity) as GameObject;
					Food2.transform.parent = BasicFood;
					Food2.transform.localScale = new Vector3(1.424812f, 1.099322f, 1f);
				}
				else if (Manager.BlueRice == 1)
				{
					Destroy(GameObject.FindWithTag("BlueCount"));
					Food1 = Instantiate(RefillFood, StartLoc, Quaternion.identity) as GameObject;
					Food1.transform.parent = BasicFood;
					Food1.transform.localScale = new Vector3(1.424812f, 1.099322f, 1f);
				}
				Manager.BlueRice -= 1;
				

			}

			if (collider.tag == "cupM")
			{
				Destroy(GameObject.FindWithTag("cupM"));
				GameObject Cup = Instantiate(selectedFoodM, DrawLocation.BarPos, Quaternion.identity) as GameObject;
				Cup.transform.parent = Parent;
				Cup.transform.localScale = new Vector3(1.2f, 1.4f, 1f);


				if (Manager.BlueRice == 3)
				{
					Destroy(GameObject.FindWithTag("BlueCount"));
					Food3 = Instantiate(CountFood2, StartLoc, Quaternion.identity) as GameObject;
					Food3.transform.parent = BasicFood;
					Food3.transform.localScale = new Vector3(1.424812f, 1.099322f, 1f);

				}
				else if (Manager.BlueRice == 2)
				{
					Destroy(GameObject.FindWithTag("BlueCount"));
					Food2 = Instantiate(CountFood1, StartLoc, Quaternion.identity) as GameObject;
					Food2.transform.parent = BasicFood;
					Food2.transform.localScale = new Vector3(1.424812f, 1.099322f, 1f);
				}
				else if (Manager.BlueRice == 1)
				{
					Destroy(GameObject.FindWithTag("BlueCount"));
					Food1 = Instantiate(RefillFood, StartLoc, Quaternion.identity) as GameObject;
					Food1.transform.parent = BasicFood;
					Food1.transform.localScale = new Vector3(1.424812f, 1.099322f, 1f);
				}
				Manager.BlueRice -= 1;
			}
		}
	}
}