using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Door_main : MonoBehaviour
{
    public GameObject btnObj;
    Button btn;
    public AudioSource source, opendoor1, opendoor2;
    public Sprite BE2, HE2;
    GameObject x;
    bool isVideo;
    // Use this for initialization
    void Start()
    {
        btn = btnObj.GetComponent<Button>();
        btn.onClick.AddListener(delegate ()
        {
            if (PlayerPrefs.GetInt("Door_exit") == 0 && GameObject.Find("RawImage") == null)
            {
                GameObject.Find("words").GetComponent<Text>().text = "I need to pry off the bars first";
            }
            else if (((PlayerPrefs.GetInt("blackkey") == 0 && PlayerPrefs.GetInt("goldenkey") == 0) && PlayerPrefs.GetInt("Door_exit") == 1) && PlayerPrefs.GetInt("BE") == 0 && PlayerPrefs.GetInt("HE") == 0 && GameObject.Find("RawImage") == null)
            {
                source.Play();
                GameObject.Find("words").GetComponent<Text>().text = "LOCKED";
            }
            else if (PlayerPrefs.GetInt("BE") == 1 && PlayerPrefs.GetInt("Door_exit") == 1 && GameObject.Find("RawImage") == null)
            {
                x = GameObject.Find("words");
                GameObject.Find("words").GetComponent<Text>().text = "Abandon hope all ye who enter here";
                opendoor1.Play();
                GameObject s = GameObject.Find("Door");
                s.GetComponent<Image>().sprite = BE2;
                Invoke("GotoEnd", 1.0f);
            }
            else if (PlayerPrefs.GetInt("HE") == 1 && PlayerPrefs.GetInt("Door_exit") == 1 && GameObject.Find("RawImage") == null)
            {
                opendoor2.Play();
                GameObject s = GameObject.Find("Door");
                s.GetComponent<Image>().sprite = HE2;
                Invoke("GotoEnd", 1.0f);
            }
        });
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("Door_exit",0) == 0
            && PlayerPrefs.GetInt("Wood2") == 1
            && PlayerPrefs.GetInt("Wood3") == 1
            && PlayerPrefs.GetInt("Wood1") == 1)
        {
            PlayerPrefs.SetInt("Door_exit", 1);
            GameObject.Find("Door").GetComponent<Decide_the_End>().enabled = true;
        }
    }
    void GotoEnd()
    {
        GameObject.Find("TheEnd").GetComponent<Fade_Control>().enabled = true;
    }
}
