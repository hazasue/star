using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickPause : MonoBehaviour
{
	public GameObject Background;
	public GameObject BackToGame;
	public GameObject Exit;
	public GameObject Option;


	Transform Pause;
    // Start is called before the first frame update
    void Start()
    {
		Pause = GameObject.Find("UI").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void ClickPause()
	{
		GameObject PauseScreen = Instantiate(Background, BGL.BGLpos, Quaternion.identity) as GameObject;
		PauseScreen.transform.parent = Pause;
		PauseScreen.transform.localScale = new Vector3(12.8f, 7.2f, 1f);

		GameObject ToGame = Instantiate(BackToGame, BTG.BTGpos, Quaternion.identity) as GameObject;
		ToGame.transform.parent = Pause;
		ToGame.transform.localScale = new Vector3(1.34f, 1.21f, 1f);

		GameObject exit = Instantiate(Exit, EL.ELpos, Quaternion.identity) as GameObject;
		exit.transform.parent = Pause;
		exit.transform.localScale = new Vector3(1.34f, 1.21f, 1f);

		GameObject option = Instantiate(Option, OL.OLpos, Quaternion.identity) as GameObject;
		option.transform.parent = Pause;
		option.transform.localScale = new Vector3(1.5f, 1.34f, 1f);

		RandomCharacter.IsPause = false;

		RandomCharacter.timeFlow1 = false;
		RandomCharacter.timeFlow2 = false;
		RandomCharacter.timeFlow3 = false;
	}
}
