using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalUIMusic : MonoBehaviour {
    public GameObject globalUIMusic, globalUIMusic2;
    public int menu = 0;
    GameObject MyUIMusic;
	// Use this for initialization
	void Start () {
        MyUIMusic = GameObject.FindGameObjectWithTag("GlobalUIMusic");
        if (MyUIMusic == null && menu == 0)
            MyUIMusic = (GameObject)Instantiate(globalUIMusic);
        else if (menu == 2)
            MyUIMusic.SetActive(false);
        //else if (PlayerPrefs.GetInt("MenuMusic") == 1)
        // {
        //    MyUIMusic.SetActive(false);
        //    MyUIMusic = (GameObject)Instantiate(globalUIMusic);
        //    PlayerPrefs.SetInt("MenuMusic", 0);
        // }
        else if (menu == 1 && MyUIMusic == null)
        {
            MyUIMusic = (GameObject)Instantiate(globalUIMusic2);
            PlayerPrefs.SetInt("MenuMusic", 1);
        }
        else if (menu == 1&& PlayerPrefs.GetInt("MenuMusic")==0)
        {
            MyUIMusic.SetActive(false);
            MyUIMusic = (GameObject)Instantiate(globalUIMusic2);
            PlayerPrefs.SetInt("MenuMusic", 1);
        }
        else if (menu == 0 && PlayerPrefs.GetInt("MenuMusic") == 1)
        {
            MyUIMusic.SetActive(false);
            MyUIMusic = (GameObject)Instantiate(globalUIMusic);
            PlayerPrefs.SetInt("MenuMusic", 0);
        }
        else if (menu == 3 && MyUIMusic == null)
        {
            MyUIMusic = (GameObject)Instantiate(globalUIMusic2);
            PlayerPrefs.SetInt("MenuMusic", 1);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
