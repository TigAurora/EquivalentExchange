using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Back_to_Scene : MonoBehaviour
{
    public int BackorMenu = 0;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            GameObject.Find("Button_audio").GetComponent<AudioSource>().Play();
        for (int i = 1; i <= 3; ++i)
            PlayerPrefs.SetFloat("Slider" + i.ToString(), GameObject.Find("Slider" + i.ToString()).GetComponent<Slider>().value);
        if (BackorMenu == 0)
            SceneManager.LoadScene(PlayerPrefs.GetString("CurrentScene", "Room1_West"));
        else
            SceneManager.LoadScene("Menu");
    }

    }
}
