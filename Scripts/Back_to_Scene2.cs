using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Back_to_Scene2 : MonoBehaviour
{
    public int BackorMenu = 0;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            GameObject.Find("Button_audio").GetComponent<AudioSource>().Play();
            SceneManager.LoadScene(PlayerPrefs.GetString("CurrentScene", "Room1_West"));
        }

    }
}
