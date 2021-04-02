using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSlush : MonoBehaviour
{
	public GameObject SlushImg1;
	public GameObject SlushImg2;
	public GameObject SlushImg3;

	public GameObject SlushImgM1;
	public GameObject SlushImgM2;
	public GameObject SlushImgM3;

	public GameObject SlushImgS1;
	public GameObject SlushImgS2;
	public GameObject SlushImgS3;
	public AudioSource SlushSound;

	Transform CreatedFood;

	// Start is called before the first frame update
	void Start()
    {
		CreatedFood = GameObject.Find("OrderFood").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void clickSlush1()
	{

		if (DragCup.SlushCup1)
		{
			Destroy(DragCup.SlushCup1);
			GameObject Slush = Instantiate(SlushImg1, DragCup.CreateSlushPos1, Quaternion.identity) as GameObject;
			Slush.transform.parent = CreatedFood;
			Slush.transform.localScale = new Vector3(1.5f, 1.6f, 1f);
			SlushSound.Play();
		}

		if (DragCupS.SlushCup1)
		{
			Destroy(DragCupS.SlushCup1);
			GameObject Slush = Instantiate(SlushImgS1, DragCup.CreateSlushPos1, Quaternion.identity) as GameObject;
			Slush.transform.parent = CreatedFood;
			Slush.transform.localScale = new Vector3(1.5f, 1.6f, 1f);
			SlushSound.Play();
		}

		if (DragCupM.SlushCup1)
		{
			Destroy(DragCupM.SlushCup1);
			GameObject Slush = Instantiate(SlushImgM1, DragCup.CreateSlushPos1, Quaternion.identity) as GameObject;
			Slush.transform.parent = CreatedFood;
			Slush.transform.localScale = new Vector3(1.5f, 1.6f, 1f);
			SlushSound.Play();
		}
	}

	public void clickSlush2()
	{
		if (DragCup.SlushCup2)
		{
			Destroy(DragCup.SlushCup2);
			GameObject Slush = Instantiate(SlushImg2, DragCup.CreateSlushPos2, Quaternion.identity) as GameObject;
			Slush.transform.parent = CreatedFood;
			Slush.transform.localScale = new Vector3(1.5f, 1.6f, 1f);
			SlushSound.Play();
		}

		if (DragCupS.SlushCup2)
		{
			Destroy(DragCupS.SlushCup2);
			GameObject Slush = Instantiate(SlushImgS2, DragCup.CreateSlushPos2, Quaternion.identity) as GameObject;
			Slush.transform.parent = CreatedFood;
			Slush.transform.localScale = new Vector3(1.5f, 1.6f, 1f);
			SlushSound.Play();
		}

		if (DragCupM.SlushCup2)
		{
			Destroy(DragCupM.SlushCup2);
			GameObject Slush = Instantiate(SlushImgM2, DragCup.CreateSlushPos2, Quaternion.identity) as GameObject;
			Slush.transform.parent = CreatedFood;
			Slush.transform.localScale = new Vector3(1.5f, 1.6f, 1f);
			SlushSound.Play();
		}
	}

	public void clickSlush3()
	{
		if (DragCup.SlushCup3)
		{
			Destroy(DragCup.SlushCup3);
			GameObject Slush = Instantiate(SlushImg3, DragCup.CreateSlushPos3, Quaternion.identity) as GameObject;
			Slush.transform.parent = CreatedFood;
			Slush.transform.localScale = new Vector3(1.5f, 1.6f, 1f);
			SlushSound.Play();
		}

		if (DragCupS.SlushCup3)
		{
			Destroy(DragCupS.SlushCup3);
			GameObject Slush = Instantiate(SlushImgS3, DragCup.CreateSlushPos3, Quaternion.identity) as GameObject;
			Slush.transform.parent = CreatedFood;
			Slush.transform.localScale = new Vector3(1.5f, 1.6f, 1f);
			SlushSound.Play();
		}

		if (DragCupM.SlushCup3)
		{
			Destroy(DragCupM.SlushCup3);
			GameObject Slush = Instantiate(SlushImgM3, DragCup.CreateSlushPos3, Quaternion.identity) as GameObject;
			Slush.transform.parent = CreatedFood;
			Slush.transform.localScale = new Vector3(1.5f, 1.6f, 1f);
			SlushSound.Play();
		}
	}
}
