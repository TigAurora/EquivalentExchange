using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Bathtub_closer_Main : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        //print(PlayerPrefs.GetInt("puzzle1"));

        if (PlayerPrefs.GetInt("id19") == 1)
        {
            GameObject item = GameObject.Find("star");
            Destroy(item);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
