using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DragCupM : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{

	Vector2 StartPos;
	public static Vector2 CreateBarPos;
	public static Vector2 CreateSlushPos1;
	public static Vector2 CreateSlushPos2;
	public static Vector2 CreateSlushPos3;

	public GameObject selectedBarCup;
	public GameObject selectedSlushCup1;
	public GameObject selectedSlushCup2;
	public GameObject selectedSlushCup3;

	public static GameObject SlushCup1;
	public static GameObject SlushCup2;
	public static GameObject SlushCup3;

	public GameObject CreateBar;
	public GameObject CreateSlush1;
	public GameObject CreateSlush2;
	public GameObject CreateSlush3;
	public AudioSource CupSound;

	Transform Parent;
	Transform Slush;

	// Start is called before the first frame update
	void Start()
	{
		StartPos = transform.position;
		CreateBarPos = CreateBar.transform.position;
		CreateSlushPos1 = CreateSlush1.transform.position;
		CreateSlushPos2 = CreateSlush2.transform.position;
		CreateSlushPos3 = CreateSlush3.transform.position;

		Parent = GameObject.Find("forCup").GetComponent<Transform>();
		Slush = GameObject.Find("SlushPos(1)").GetComponent<Transform>();
	}

	// Update is called once per frame
	void Update()
	{

	}

	public void OnBeginDrag(PointerEventData eventData)
	{
		Manager.IsDrag = true;
	}

	public void OnDrag(PointerEventData eventData)
	{
		transform.position = eventData.position;
	}

	public void OnEndDrag(PointerEventData eventData)
	{
		transform.position = StartPos;
		Manager.IsDrag = false;
		CupSound.Play();
	}

	public void OnTriggerExit2D(Collider2D collider)
	{
		if (Manager.IsDrag == false)
		{
			if (collider.tag == "bar")
			{
				Destroy(GameObject.FindWithTag("cup"));

				Destroy(GameObject.FindWithTag("cupM"));

				Destroy(GameObject.FindWithTag("cupS"));

				GameObject Cup = Instantiate(selectedBarCup, CreateBarPos, Quaternion.identity) as GameObject;
				Cup.transform.parent = Parent;
				Cup.transform.localScale = new Vector3(1.2f, 1.4f, 1f);
			}

			if (collider.tag == "slushPos1")
			{
				SlushCup1 = Instantiate(selectedSlushCup1, CreateSlushPos1, Quaternion.identity) as GameObject;
				SlushCup1.transform.parent = Slush;
				SlushCup1.transform.localScale = new Vector3(1.2f, 1.4f, 1f);
			}

			if (collider.tag == "slushPos2")
			{
				SlushCup2 = Instantiate(selectedSlushCup2, CreateSlushPos2, Quaternion.identity) as GameObject;
				SlushCup2.transform.parent = Parent;
				SlushCup2.transform.localScale = new Vector3(1.2f, 1.4f, 1f);
			}

			if (collider.tag == "slushPos3")
			{
				SlushCup3 = Instantiate(selectedSlushCup3, CreateSlushPos3, Quaternion.identity) as GameObject;
				SlushCup3.transform.parent = Parent;
				SlushCup3.transform.localScale = new Vector3(1.2f, 1.4f, 1f);
			}

			if (collider.tag == "slushCup1")
			{
				Destroy(GameObject.FindWithTag("slushCup1"));
			}

			if (collider.tag == "slushCup2")
			{
				Destroy(GameObject.FindWithTag("slushCup2"));
			}

			if (collider.tag == "slushCup3")
			{
				Destroy(GameObject.FindWithTag("slushCup3"));
			}
		}
	}
}
