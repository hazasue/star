using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShuterDown : MonoBehaviour
{
    public GameObject start_shuter;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(start_shuter.transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        if (ReMoveToReady.game_clear)
        {
            Vector2 pos = start_shuter.transform.position;

            pos.y = pos.y - 5f;

            start_shuter.transform.position = pos;

            if (start_shuter.transform.position.y <= 533f)
            {
                SceneManager.LoadScene("Ready");
                ReMoveToReady.game_clear = false;
            }
        }


    }
}
