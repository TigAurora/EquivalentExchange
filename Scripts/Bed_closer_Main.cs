using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Bed_closer_Main : MonoBehaviour
{
    public Sprite pillowexpan, amuletexpan,Nonepng;
    GameObject temp;
    // Use this for initialization
    void Start()
    {
        GameObject.Find("words").GetComponent<Text>().text = "I haven't had a deep sleep in bed for months";
        if (PlayerPrefs.GetInt("id8") == 0)
        {
            temp = GameObject.Find("amulet");
            temp.GetComponent<Collider2D>().enabled = false;
        }
        if (PlayerPrefs.GetInt("pillowtear") == 1)
        {
            temp = GameObject.Find("pillow");
            temp.GetComponent<Image>().sprite = pillowexpan;
        }
        if (PlayerPrefs.GetInt("id8") == 1)
        {
            Destroy(GameObject.Find("amulet"));
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("pillowtear") == 1)
        {
            if (PlayerPrefs.GetInt("id8") == 0)
            {
                temp = GameObject.Find("amulet");
                temp.GetComponent<Collider2D>().enabled = true;
                temp.GetComponent<Image>().sprite = amuletexpan;
            }
        }
    }
}
