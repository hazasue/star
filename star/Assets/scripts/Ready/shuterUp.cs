using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class shuterUp : MonoBehaviour
{
    //셔터 버튼 가져옴
    public GameObject shuter;

    void Start()
    {
        //Debug.Log(shuter.transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        if (moveToStart.shuterclick)
        {
            //셔터의 포지션 가져옴
            Vector2 pos = shuter.transform.position;

            //매 프레임마다 5씩 올림
            pos.y = pos.y + 5f;

            //매 프레임마다 셔터 포지션에 넣음
            shuter.transform.position = pos;

			if (shuter.transform.position.y >= 891f)
			{
				SceneManager.LoadScene("start");
				moveToStart.shuterclick = false;
			}
        }
    }
}
