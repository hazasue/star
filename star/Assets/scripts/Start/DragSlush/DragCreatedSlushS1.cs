using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DragCreatedSlushS1 : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
	Vector2 StartPos;
	bool IsDrag;
	public GameObject hchar1;
	public GameObject hchar2;
	public GameObject hchar3;
	public GameObject hchar4;
	public GameObject hchar5;
	public GameObject hchar6;
	public GameObject hchar7;
	public GameObject hchar8;
	public GameObject hchar9;

	public GameObject achar1;
	public GameObject achar2;
	public GameObject achar3;
	public GameObject achar4;
	public GameObject achar5;
	public GameObject achar6;
	public GameObject achar7;
	public GameObject achar8;
	public GameObject achar9;

	GameObject Loc1;
	GameObject Loc2;
	GameObject Loc3;

	GameObject hChar;
	GameObject aChar;

	Transform Parent;
	Transform CharacterManager;
	// Start is called before the first frame update
	void Start()
	{
		StartPos = transform.position;

		IsDrag = false;

		CharacterManager = GameObject.Find("characterManager").GetComponent<Transform>();

		Loc1 = RandomCharacter.LocationChar1;
		Loc2 = RandomCharacter.LocationChar2;
		Loc3 = RandomCharacter.LocationChar3;
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
			if (collider.gameObject == RandomCharacter.Char1)
			{
				if (RandomCharacter.cf1 == "1")
				{
					hChar = Instantiate(hchar1, Loc1.transform.position, Quaternion.identity) as GameObject;
					Destroy(hChar, 0.5f);
				}
				else if (RandomCharacter.cf1 == "2")
				{
					hChar = Instantiate(hchar2, Loc1.transform.position, Quaternion.identity) as GameObject;
					Destroy(hChar, 0.5f);
				}
				else if (RandomCharacter.cf1 == "3")
				{
					hChar = Instantiate(hchar3, Loc1.transform.position, Quaternion.identity) as GameObject;
					Destroy(hChar, 0.5f);
				}
				else if (RandomCharacter.cf1 == "4")
				{
					hChar = Instantiate(hchar4, Loc1.transform.position, Quaternion.identity) as GameObject;
					Destroy(hChar, 0.5f);
				}
				else if (RandomCharacter.cf1 == "5")
				{
					hChar = Instantiate(hchar5, Loc1.transform.position, Quaternion.identity) as GameObject;
					Destroy(hChar, 0.5f);
				}
				else if (RandomCharacter.cf1 == "6")
				{
					hChar = Instantiate(hchar6, Loc1.transform.position, Quaternion.identity) as GameObject;
					Destroy(hChar, 0.5f);
				}
				else if (RandomCharacter.cf1 == "7")
				{
					hChar = Instantiate(hchar7, Loc1.transform.position, Quaternion.identity) as GameObject;
					Destroy(hChar, 0.5f);
				}
				else if (RandomCharacter.cf1 == "8")
				{
					hChar = Instantiate(hchar8, Loc1.transform.position, Quaternion.identity) as GameObject;
					Destroy(hChar, 0.5f);
				}
				else
				{
					hChar = Instantiate(hchar9, Loc1.transform.position, Quaternion.identity) as GameObject;
					Destroy(hChar, 0.5f);
				}
				if (RandomCharacter.food1 && RandomCharacter.food1.tag == "SlushOrderS1")
				{

					Destroy(RandomCharacter.food1);
					Manager.money += Money_manager.or_slush_money_S;
					Manager.day_money += Money_manager.or_slush_money_S;
					Destroy(gameObject);
					if (!RandomCharacter.food12 && !RandomCharacter.food13)
					{
						Destroy(RandomCharacter.Feel1);
						Destroy(RandomCharacter.Char1);
						RandomCharacter.charStay1 = 0f;
						RandomCharacter.CharProduce1 = true;
						hChar.transform.parent = CharacterManager;
						hChar.transform.localScale = new Vector3(3.05f, 3.85f, 1f);
					}
				}
				else if (RandomCharacter.food12 && RandomCharacter.food12.tag == "SlushOrderS1")
				{
					Destroy(RandomCharacter.food12);
					Manager.money += Money_manager.or_slush_money_S;
					Manager.day_money += Money_manager.or_slush_money_S;
					Destroy(gameObject);
					if (!RandomCharacter.food1 && !RandomCharacter.food13)
					{
						Destroy(RandomCharacter.Feel1);
						Destroy(RandomCharacter.Char1);
						RandomCharacter.charStay1 = 0f;
						RandomCharacter.CharProduce1 = true;
						hChar.transform.parent = CharacterManager;
						hChar.transform.localScale = new Vector3(3.05f, 3.85f, 1f);
					}
				}
				else if (RandomCharacter.food13 && RandomCharacter.food13.tag == "SlushOrderS1")
				{
					Destroy(RandomCharacter.food13);
					Manager.money += Money_manager.or_slush_money_S;
					Manager.day_money += Money_manager.or_slush_money_S;
					Destroy(gameObject);
					if (!RandomCharacter.food1 && !RandomCharacter.food12)
					{
						Destroy(RandomCharacter.Feel1);
						Destroy(RandomCharacter.Char1);
						RandomCharacter.charStay1 = 0f;
						RandomCharacter.CharProduce1 = true;
						hChar.transform.parent = CharacterManager;
						hChar.transform.localScale = new Vector3(3.05f, 3.85f, 1f);
					}
				}
				if (RandomCharacter.food1.tag != "SlushOrderS1" && RandomCharacter.food12.tag != "SlushOrderS1" && RandomCharacter.food13.tag != "SlushOrderS1")
				{
					if (RandomCharacter.cf1 == "1")
					{
						aChar = Instantiate(achar1, Loc1.transform.position, Quaternion.identity) as GameObject;
						aChar.transform.parent = CharacterManager;
						Destroy(aChar, 1.3f);
					}
					else if (RandomCharacter.cf1 == "2")
					{
						aChar = Instantiate(achar2, Loc1.transform.position, Quaternion.identity) as GameObject;
						aChar.transform.parent = CharacterManager;
						Destroy(aChar, 1.3f);
					}
					else if (RandomCharacter.cf1 == "3")
					{
						aChar = Instantiate(achar3, Loc1.transform.position, Quaternion.identity) as GameObject;
						aChar.transform.parent = CharacterManager;
						Destroy(aChar, 1.3f);
					}
					else if (RandomCharacter.cf1 == "4")
					{
						aChar = Instantiate(achar4, Loc1.transform.position, Quaternion.identity) as GameObject;
						aChar.transform.parent = CharacterManager;
						Destroy(aChar, 1.3f);
					}
					else if (RandomCharacter.cf1 == "5")
					{
						aChar = Instantiate(achar5, Loc1.transform.position, Quaternion.identity) as GameObject;
						aChar.transform.parent = CharacterManager;
						Destroy(aChar, 1.3f);
					}
					else if (RandomCharacter.cf1 == "6")
					{
						aChar = Instantiate(achar6, Loc1.transform.position, Quaternion.identity) as GameObject;
						aChar.transform.parent = CharacterManager;
						Destroy(aChar, 1.3f);
					}
					else if (RandomCharacter.cf1 == "7")
					{
						aChar = Instantiate(achar7, Loc1.transform.position, Quaternion.identity) as GameObject;
						aChar.transform.parent = CharacterManager;
						Destroy(aChar, 1.3f);
					}
					else if (RandomCharacter.cf1 == "8")
					{
						aChar = Instantiate(achar8, Loc1.transform.position, Quaternion.identity) as GameObject;
						aChar.transform.parent = CharacterManager;
						Destroy(aChar, 1.3f);
					}
					else
					{
						aChar = Instantiate(achar9, Loc1.transform.position, Quaternion.identity) as GameObject;
						aChar.transform.parent = CharacterManager;
						Destroy(aChar, 1.3f);
					}
				}

			}

			if (collider.gameObject == RandomCharacter.Char2)
			{
				if (RandomCharacter.cf2 == "1")
				{
					hChar = Instantiate(hchar1, Loc2.transform.position, Quaternion.identity) as GameObject;
					Destroy(hChar, 0.5f);
				}
				else if (RandomCharacter.cf2 == "2")
				{
					hChar = Instantiate(hchar2, Loc2.transform.position, Quaternion.identity) as GameObject;
					Destroy(hChar, 0.5f);
				}
				else if (RandomCharacter.cf2 == "3")
				{
					hChar = Instantiate(hchar3, Loc2.transform.position, Quaternion.identity) as GameObject;
					Destroy(hChar, 0.5f);
				}
				else if (RandomCharacter.cf2 == "4")
				{
					hChar = Instantiate(hchar4, Loc2.transform.position, Quaternion.identity) as GameObject;
					Destroy(hChar, 0.5f);
				}
				else if (RandomCharacter.cf2 == "5")
				{
					hChar = Instantiate(hchar5, Loc2.transform.position, Quaternion.identity) as GameObject;
					Destroy(hChar, 0.5f);
				}
				else if (RandomCharacter.cf2 == "6")
				{
					hChar = Instantiate(hchar6, Loc2.transform.position, Quaternion.identity) as GameObject;
					Destroy(hChar, 0.5f);
				}
				else if (RandomCharacter.cf2 == "7")
				{
					hChar = Instantiate(hchar7, Loc2.transform.position, Quaternion.identity) as GameObject;
					Destroy(hChar, 0.5f);
				}
				else if (RandomCharacter.cf2 == "8")
				{
					hChar = Instantiate(hchar8, Loc2.transform.position, Quaternion.identity) as GameObject;
					Destroy(hChar, 0.5f);
				}
				else
				{
					hChar = Instantiate(hchar9, Loc2.transform.position, Quaternion.identity) as GameObject;
					Destroy(hChar, 0.5f);
				}
				if (RandomCharacter.food2 && RandomCharacter.food2.tag == "SlushOrderS1")
				{
					Destroy(RandomCharacter.food2);
					Manager.money += Money_manager.or_slush_money_S;
					Manager.day_money += Money_manager.or_slush_money_S;
					Destroy(gameObject);
					if (!RandomCharacter.food22 && !RandomCharacter.food23)
					{
						Destroy(RandomCharacter.Feel2);
						Destroy(RandomCharacter.Char2);
						RandomCharacter.charStay2 = 0f;
						RandomCharacter.CharProduce2 = true;
						hChar.transform.parent = CharacterManager;
						hChar.transform.localScale = new Vector3(3.05f, 3.85f, 1f);
					}

				}
				else if (RandomCharacter.food22 && RandomCharacter.food22.tag == "SlushOrderS1")
				{
					Destroy(RandomCharacter.food22);
					Manager.money += Money_manager.or_slush_money_S;
					Manager.day_money += Money_manager.or_slush_money_S;
					Destroy(gameObject);
					if (!RandomCharacter.food2 && !RandomCharacter.food23)
					{
						Destroy(RandomCharacter.Feel2);
						Destroy(RandomCharacter.Char2);
						RandomCharacter.charStay2 = 0f;
						RandomCharacter.CharProduce2 = true;
						hChar.transform.parent = CharacterManager;
						hChar.transform.localScale = new Vector3(3.05f, 3.85f, 1f);
					}

				}
				else if (RandomCharacter.food23 && RandomCharacter.food23.tag == "SlushOrderS1")
				{
					Destroy(RandomCharacter.food23);
					Manager.money += Money_manager.or_slush_money_S;
					Manager.day_money += Money_manager.or_slush_money_S;
					Destroy(gameObject);
					if (!RandomCharacter.food2 && !RandomCharacter.food22)
					{
						Destroy(RandomCharacter.Feel2);
						Destroy(RandomCharacter.Char2);
						RandomCharacter.charStay2 = 0f;
						RandomCharacter.CharProduce2 = true;
						hChar.transform.parent = CharacterManager;
						hChar.transform.localScale = new Vector3(3.05f, 3.85f, 1f);
					}

				}
				if (RandomCharacter.food2.tag != "SlushOrderS1" && RandomCharacter.food22.tag != "SlushOrderS1" && RandomCharacter.food23.tag != "SlushOrderS1")
				{
					if (RandomCharacter.cf2 == "1")
					{
						aChar = Instantiate(achar1, Loc2.transform.position, Quaternion.identity) as GameObject;
						aChar.transform.parent = CharacterManager;
						Destroy(aChar, 1.3f);
					}
					else if (RandomCharacter.cf2 == "2")
					{
						aChar = Instantiate(achar2, Loc2.transform.position, Quaternion.identity) as GameObject;
						aChar.transform.parent = CharacterManager;
						Destroy(aChar, 1.3f);
					}
					else if (RandomCharacter.cf2 == "3")
					{
						aChar = Instantiate(achar3, Loc2.transform.position, Quaternion.identity) as GameObject;
						aChar.transform.parent = CharacterManager;
						Destroy(aChar, 1.3f);
					}
					else if (RandomCharacter.cf2 == "4")
					{
						aChar = Instantiate(achar4, Loc2.transform.position, Quaternion.identity) as GameObject;
						aChar.transform.parent = CharacterManager;
						Destroy(aChar, 1.3f);
					}
					else if (RandomCharacter.cf2 == "5")
					{
						aChar = Instantiate(achar5, Loc2.transform.position, Quaternion.identity) as GameObject;
						aChar.transform.parent = CharacterManager;
						Destroy(aChar, 1.3f);
					}
					else if (RandomCharacter.cf2 == "6")
					{
						aChar = Instantiate(achar6, Loc2.transform.position, Quaternion.identity) as GameObject;
						aChar.transform.parent = CharacterManager;
						Destroy(aChar, 1.3f);
					}
					else if (RandomCharacter.cf2 == "7")
					{
						aChar = Instantiate(achar7, Loc2.transform.position, Quaternion.identity) as GameObject;
						aChar.transform.parent = CharacterManager;
						Destroy(aChar, 1.3f);
					}
					else if (RandomCharacter.cf2 == "8")
					{
						aChar = Instantiate(achar8, Loc2.transform.position, Quaternion.identity) as GameObject;
						aChar.transform.parent = CharacterManager;
						Destroy(aChar, 1.3f);
					}
					else
					{
						aChar = Instantiate(achar9, Loc2.transform.position, Quaternion.identity) as GameObject;
						aChar.transform.parent = CharacterManager;
						Destroy(aChar, 1.3f);
					}
				}
			}

			if (collider.gameObject == RandomCharacter.Char3)
			{
				if (RandomCharacter.cf3 == "1")
				{
					hChar = Instantiate(hchar1, Loc3.transform.position, Quaternion.identity) as GameObject;
					Destroy(hChar, 0.5f);
				}
				else if (RandomCharacter.cf3 == "2")
				{
					hChar = Instantiate(hchar2, Loc3.transform.position, Quaternion.identity) as GameObject;
					Destroy(hChar, 0.5f);
				}
				else if (RandomCharacter.cf3 == "3")
				{
					hChar = Instantiate(hchar3, Loc3.transform.position, Quaternion.identity) as GameObject;
					Destroy(hChar, 0.5f);
				}
				else if (RandomCharacter.cf3 == "4")
				{
					hChar = Instantiate(hchar4, Loc3.transform.position, Quaternion.identity) as GameObject;
					Destroy(hChar, 0.5f);
				}
				else if (RandomCharacter.cf3 == "5")
				{
					hChar = Instantiate(hchar5, Loc3.transform.position, Quaternion.identity) as GameObject;
					Destroy(hChar, 0.5f);
				}
				else if (RandomCharacter.cf3 == "6")
				{
					hChar = Instantiate(hchar6, Loc3.transform.position, Quaternion.identity) as GameObject;
					Destroy(hChar, 0.5f);
				}
				else if (RandomCharacter.cf3 == "7")
				{
					hChar = Instantiate(hchar7, Loc3.transform.position, Quaternion.identity) as GameObject;
					Destroy(hChar, 0.5f);
				}
				else if (RandomCharacter.cf3 == "8")
				{
					hChar = Instantiate(hchar8, Loc3.transform.position, Quaternion.identity) as GameObject;
					Destroy(hChar, 0.5f);
				}
				else
				{
					hChar = Instantiate(hchar9, Loc3.transform.position, Quaternion.identity) as GameObject;
					Destroy(hChar, 0.5f);
				}

				if (RandomCharacter.food3 && RandomCharacter.food3.tag == "SlushOrderS1")
				{
					Destroy(RandomCharacter.food3);
					Manager.money += Money_manager.or_slush_money_S;
					Manager.day_money += Money_manager.or_slush_money_S;
					Destroy(gameObject);
					if (!RandomCharacter.food32 && !RandomCharacter.food33)
					{
						Destroy(RandomCharacter.Feel3);
						Destroy(RandomCharacter.Char3);
						RandomCharacter.charStay3 = 0f;
						RandomCharacter.CharProduce3 = true;
						hChar.transform.parent = CharacterManager;
						hChar.transform.localScale = new Vector3(3.05f, 3.85f, 1f);
					}

				}
				else if (RandomCharacter.food32 && RandomCharacter.food32.tag == "SlushOrderS1")
				{
					Destroy(RandomCharacter.food32);
					Manager.money += Money_manager.or_slush_money_S;
					Manager.day_money += Money_manager.or_slush_money_S;
					Destroy(gameObject);
					if (!RandomCharacter.food3 && !RandomCharacter.food33)
					{
						Destroy(RandomCharacter.Feel3);
						Destroy(RandomCharacter.Char3);
						RandomCharacter.charStay3 = 0f;
						RandomCharacter.CharProduce3 = true;
						hChar.transform.parent = CharacterManager;
						hChar.transform.localScale = new Vector3(3.05f, 3.85f, 1f);
					}

				}
				else if (RandomCharacter.food33 && RandomCharacter.food33.tag == "SlushOrderS1")
				{
					Destroy(RandomCharacter.food33);
					Manager.money += Money_manager.or_slush_money_S;
					Manager.day_money += Money_manager.or_slush_money_S;
					Destroy(gameObject);
					if (!RandomCharacter.food3 && !RandomCharacter.food32)
					{
						Destroy(RandomCharacter.Feel3);
						Destroy(RandomCharacter.Char3);
						RandomCharacter.charStay3 = 0f;
						RandomCharacter.CharProduce3 = true;
						hChar.transform.parent = CharacterManager;
						hChar.transform.localScale = new Vector3(3.05f, 3.85f, 1f);
					}

				}
				if (RandomCharacter.food3.tag != "SlushOrderS1" && RandomCharacter.food32.tag != "SlushOrderS1" && RandomCharacter.food33.tag != "SlushOrderS1")
				{
					if (RandomCharacter.cf3 == "1")
					{
						aChar = Instantiate(achar1, Loc3.transform.position, Quaternion.identity) as GameObject;
						aChar.transform.parent = CharacterManager;
						Destroy(aChar, 1.3f);
					}
					else if (RandomCharacter.cf3 == "2")
					{
						aChar = Instantiate(achar2, Loc3.transform.position, Quaternion.identity) as GameObject;
						aChar.transform.parent = CharacterManager;
						Destroy(aChar, 1.3f);
					}
					else if (RandomCharacter.cf3 == "3")
					{
						aChar = Instantiate(achar3, Loc3.transform.position, Quaternion.identity) as GameObject;
						aChar.transform.parent = CharacterManager;
						Destroy(aChar, 1.3f);
					}
					else if (RandomCharacter.cf3 == "4")
					{
						aChar = Instantiate(achar4, Loc3.transform.position, Quaternion.identity) as GameObject;
						aChar.transform.parent = CharacterManager;
						Destroy(aChar, 1.3f);
					}
					else if (RandomCharacter.cf3 == "5")
					{
						aChar = Instantiate(achar5, Loc3.transform.position, Quaternion.identity) as GameObject;
						aChar.transform.parent = CharacterManager;
						Destroy(aChar, 1.3f);
					}
					else if (RandomCharacter.cf3 == "6")
					{
						aChar = Instantiate(achar6, Loc3.transform.position, Quaternion.identity) as GameObject;
						aChar.transform.parent = CharacterManager;
						Destroy(aChar, 1.3f);
					}
					else if (RandomCharacter.cf3 == "7")
					{
						aChar = Instantiate(achar7, Loc3.transform.position, Quaternion.identity) as GameObject;
						aChar.transform.parent = CharacterManager;
						Destroy(aChar, 1.3f);
					}
					else if (RandomCharacter.cf3 == "8")
					{
						aChar = Instantiate(achar8, Loc3.transform.position, Quaternion.identity) as GameObject;
						aChar.transform.parent = CharacterManager;
						Destroy(aChar, 1.3f);
					}
					else
					{
						aChar = Instantiate(achar9, Loc3.transform.position, Quaternion.identity) as GameObject;
						aChar.transform.parent = CharacterManager;
						Destroy(aChar, 1.3f);
					}
				}
			}
			if (aChar)
			{
				aChar.transform.parent = CharacterManager;
				aChar.transform.localScale = new Vector2(3.05f, 3.825f);
			}
			if (collider.tag == "trashcan")
			{
				Destroy(gameObject);
			}
		}
	}
}


