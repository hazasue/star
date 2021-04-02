using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DragRiceBlue : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{

	public static Vector2 StartPos;

	public static bool IsDrag;

	public GameObject CountFood2;
	public GameObject CountFood1;
	public GameObject RefillFood;

	public GameObject ladle;
	GameObject Ladle;

	public GameObject CF3;
	public GameObject CF2;
	public GameObject CF1;
	GameObject Rice;


	public GameObject selectedFood;
	public GameObject selectedFoodS;
	public GameObject selectedFoodM;

	Transform Parent;
	public static Transform BasicFood;

	// Start is called before the first frame update
	void Start()
	{
		IsDrag = false;

		StartPos = transform.position;

		Parent = GameObject.Find("OrderFood").GetComponent<Transform>();
		BasicFood = GameObject.Find("BasicFood").GetComponent<Transform>();

	}

	// Update is called once per frame
	void Update()
	{

	}

	public void OnBeginDrag(PointerEventData eventData)
	{
		IsDrag = true;
		if (Manager.BlueRice == 3)
		{
			Rice = Instantiate(CF3, StartPos, Quaternion.identity) as GameObject;
			Rice.transform.parent = BasicFood;
			Rice.transform.localScale = new Vector3(1.424812f, 1.099322f, 1f);
		}
		else if (Manager.BlueRice == 2)
		{
			Rice = Instantiate(CF2, StartPos, Quaternion.identity) as GameObject;
			Rice.transform.parent = BasicFood;
			Rice.transform.localScale = new Vector3(1.424812f, 1.099322f, 1f);
		}
		else if (Manager.BlueRice == 1)
		{
			Rice = Instantiate(CF1, StartPos, Quaternion.identity) as GameObject;
			Rice.transform.parent = BasicFood;
			Rice.transform.localScale = new Vector3(1.424812f, 1.099322f, 1f);
		}
	}

	public void OnDrag(PointerEventData eventData)
	{
		if (Ladle)
		{
			Destroy(Ladle);
		}
		transform.position = eventData.position;
		Ladle = Instantiate(ladle, transform.position, Quaternion.identity) as GameObject;
		Ladle.transform.parent = Parent;
		Ladle.transform.localScale = new Vector3(1f, 1.2f, 1f);

		gameObject.transform.localScale = new Vector3(0.01f, 0.01f, 1f);
	}

	public void OnEndDrag(PointerEventData eventData)
	{
		Destroy(Rice);
		gameObject.transform.localScale = new Vector3(1.424812f, 1.099322f, 1f);
		transform.position = StartPos;
		IsDrag = false;
		Destroy(Ladle);
	}
}