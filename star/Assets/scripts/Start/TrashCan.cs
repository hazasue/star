using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCan : MonoBehaviour
{
	GameObject trash;
	GameObject Trash;
	public GameObject trashCan;
	public GameObject Trashcan;

	Transform trashpos;
    // Start is called before the first frame update
    void Start()
    {
		trashpos = GameObject.Find("Table").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public void OnTriggerEnter2D(Collider2D collider)
	{
		trash = Instantiate(trashCan, transform.position, Quaternion.identity) as GameObject;
		trash.transform.parent = trashpos;
		trash.transform.localScale = new Vector2(0.880016f, 1.6f);
	}

	public void OnTriggerExit2D(Collider2D collider)
	{
		Destroy(trash);
		Trash = Instantiate(Trashcan, transform.position, Quaternion.identity) as GameObject;
		Trash.transform.parent = trashpos;
		Trash.transform.localScale = new Vector2(0.880016f, 1.6f);

		Destroy(Trash, 0.2f);
	}
}
