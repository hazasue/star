using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coveroff : MonoBehaviour
{
    public GameObject Cover;
    int count;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        count += 1;
        if (count >= 200)
        {
            Cover.SetActive(false);
        }

        if (count >= 2000)
        {
            Title();
        }

    }

    public void Title()
    {
        SceneManager.LoadScene("Title");
    }
}
