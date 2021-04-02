using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{

	Vector2 StartPos;

	// Start is called before the first frame update
	void Start()
    {
		StartPos = transform.position;
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
	}

	public void OnTriggerExit2D(Collider2D collider)
	{
		if (Manager.IsDrag == false)
		{
			if (collider.tag == "trashcan")
			{
				Destroy(gameObject);
			}
		}
	}
}
