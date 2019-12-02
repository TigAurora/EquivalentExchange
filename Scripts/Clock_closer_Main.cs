using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Clock_closer_Main : MonoBehaviour
{

    public int id2=0;
    // Use this for initialization
    void Start()
    {
        //print(PlayerPrefs.GetInt("puzzle1"));
        id2 = PlayerPrefs.GetInt("id2");

        if (id2 == 1)
        {
            GameObject item = GameObject.Find("minutehand");
            Destroy(item);
        }
            //print(temp.name);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
