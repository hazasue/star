using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragStick : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{

	public GameObject stick;
	public GameObject stickS;
	public GameObject stickM;

	bool IsDrag;

	Vector2 StartPos;
    // Start is called before the first frame update
    void Start()
    {
		IsDrag = false;

		StartPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void OnBeginDrag(PointerEventData eventData)
	{
		IsDrag = true;
	}

	public void OnDrag(PointerEventData eventData)
	{
		transform.position = eventData.position;
	}

	public void OnEndDrag(PointerEventData eventData)
	{
		transform.position = StartPos;
		IsDrag = false;
	}

	public void OnTriggerExit2D(Collider2D collider)
	{
		if (IsDrag == false)
		{
			if(collider.tag == "cup")
			{
				Destroy(gameObject);
				Destroy(GameObject.FindWithTag("cup"));
				GameObject CupGrill = Instantiate(stick, DragCup.CreateBarPos, Quaternion.identity) as GameObject;
				CupGrill.transform.parent = GrillStick.Grill;
				CupGrill.transform.localScale = new Vector3(1.5f, 1.6f, 1f);
			}

			if(collider.tag == "cupS")
			{
				Destroy(gameObject);
				Destroy(GameObject.FindWithTag("cupS"));
				GameObject CupGrill = Instantiate(stickS, DragCup.CreateBarPos, Quaternion.identity) as GameObject;
				CupGrill.transform.parent = GrillStick.Grill;
				CupGrill.transform.localScale = new Vector3(0.9f, 1.2f, 1f);
			}

			if (collider.tag == "cupM")
			{
				Destroy(gameObject);
				Destroy(GameObject.FindWithTag("cupM"));
				GameObject CupGrill = Instantiate(stickM, DragCup.CreateBarPos, Quaternion.identity) as GameObject;
				CupGrill.transform.parent = GrillStick.Grill;
				CupGrill.transform.localScale = new Vector3(1.2f, 1.4f, 1f);
			}

			if (collider.tag == "trashcan")
			{
				Destroy(gameObject);
			}
		}
	}
}
