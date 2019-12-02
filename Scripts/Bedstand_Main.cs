using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Bedstand_Main : MonoBehaviour
{
    public int id3;
    public Sprite Puzzle2expan, Nonepng,Knifeexpan;
    Image ibtn, btn;
    GameObject p2,knife;
    // Use this for initialization
    void Start()
    {
        PlayerPrefs.SetInt("stand1", 0);
        PlayerPrefs.SetInt("stand3", 0);
        id3 = PlayerPrefs.GetInt("id3");
        p2 = GameObject.Find("puzzle2");
        knife = GameObject.Find("knife");
        btn = knife.GetComponent<Image>();
        ibtn = p2.GetComponent<Image>();

        if (id3 == 1)
        {
            Destroy(p2);
        }
        if (PlayerPrefs.GetInt("id7") == 1)
        {
            Destroy(knife);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (id3 == 0 && p2!=null)
        {
            if (PlayerPrefs.GetInt("stand1") == 0)
            {
                ibtn.GetComponent<Image>().sprite = Nonepng;
                ibtn.GetComponent<Collider2D>().enabled = false;
                ibtn.raycastTarget = false;
            }
            else
            {
                ibtn.GetComponent<Image>().sprite = Puzzle2expan;
                ibtn.GetComponent<Collider2D>().enabled = true;
                ibtn.raycastTarget = true;
            }
        }
        if (PlayerPrefs.GetInt("id7") == 0 && GameObject.Find("knife") != null)
        {
            if (PlayerPrefs.GetInt("stand3") == 0)
            {
                btn.GetComponent<Image>().sprite = Nonepng;
                btn.GetComponent<Collider2D>().enabled = false;
                btn.raycastTarget = false;
            }
            else
            {
                btn.GetComponent<Image>().sprite = Knifeexpan;
                btn.GetComponent<Collider2D>().enabled = true;
                btn.raycastTarget = true;
            }
        }
    }
}
