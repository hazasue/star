using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deletUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void deleteUI()
	{
		Destroy(GameObject.FindWithTag("BackgroundUI"));
		Destroy(GameObject.FindWithTag("ExitUI"));
		Destroy(GameObject.FindWithTag("BackToTitleUI"));
		Destroy(GameObject.FindWithTag("OptionUI"));

		RandomCharacter.IsPause = true;

		if (RandomCharacter.time >= 1)
		{
			RandomCharacter.timeFlow1 = true;
		}
		if (RandomCharacter.time >= 5)
		{
			RandomCharacter.timeFlow2 = true;
		}
		if (RandomCharacter.time >= 10)
		{
			RandomCharacter.timeFlow3 = true;
		}
	}

	public void BackToReady()
	{
		SceneManager.LoadScene("Ready");
		Manager.Day += 1;
	}

	public void BackToOption()
	{
		SceneManager.LoadScene("");
	}
}
