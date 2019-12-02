using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Door_closer_Main : MonoBehaviour
{
    public int id1 = 0,id2;
    int i;
    public string puzzle1on, puzzle2on,puzzle3on, puzzle4on;
    public Sprite Puzzle1expan, Puzzle2expan, Puzzle3expan, Puzzle4expan;
    Image img;
    public AudioSource source;
    // Use this for initialization
    void Start()
    {
        //print(PlayerPrefs.GetInt("puzzle1"));

        id2 = PlayerPrefs.GetInt("id2");
        id1 = PlayerPrefs.GetInt("id1");

        puzzle1on = PlayerPrefs.GetString("1","off");
        puzzle2on = PlayerPrefs.GetString("3", "off");
        puzzle3on = PlayerPrefs.GetString("12", "off");
        puzzle4on = PlayerPrefs.GetString("9","off");

        if (puzzle1on == "off" && puzzle2on == "off" && puzzle3on == "off" && puzzle4on == "off")
            GameObject.Find("words").GetComponent<Text>().text = "There should be something here";
        if (puzzle1on == "on")
        {
            GameObject p1 = GameObject.Find("p1");
            img = p1.GetComponent<Image>();
            img.GetComponent<Image>().sprite = Puzzle1expan;
            GameObject item = GameObject.Find("puzzle1");
            Destroy(item);
            //Destroy(GameObject.Find("puzzle_parent").gameObject);
            //PlayerPrefs.SetString("1", "on");
        }
        if (puzzle2on == "on")
        {
            GameObject p2 = GameObject.Find("p2");
            img = p2.GetComponent<Image>();
            img.GetComponent<Image>().sprite = Puzzle2expan;
            GameObject item = GameObject.Find("puzzle2");
            Destroy(item);
            //Destroy(GameObject.Find("puzzle_parent").gameObject);
            //PlayerPrefs.SetString("1", "on");
        }
        if (puzzle3on == "on")
        {
            GameObject p3 = GameObject.Find("p3");
            img = p3.GetComponent<Image>();
            img.GetComponent<Image>().sprite = Puzzle3expan;
            GameObject item = GameObject.Find("puzzle3");
            Destroy(item);
            //Destroy(GameObject.Find("puzzle_parent").gameObject);
            //PlayerPrefs.SetString("1", "on");
        }
        if (puzzle4on == "on")
        {
            GameObject p4 = GameObject.Find("p4");
            img = p4.GetComponent<Image>();
            img.GetComponent<Image>().sprite = Puzzle4expan;
            GameObject item = GameObject.Find("puzzle4");
            Destroy(item);
            //Destroy(GameObject.Find("puzzle_parent").gameObject);
            //PlayerPrefs.SetString("1", "on");
        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}
