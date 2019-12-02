using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Books_Main : MonoBehaviour
{

    public Sprite Booksexpan;
    Image ibtn;

    // Use this for initialization
    void Start()
    {
        if (PlayerPrefs.GetString("CabLight") == "on")
        {
            Destroy(GameObject.Find("Room").GetComponent("Arrange"));
            Destroy(GameObject.Find("blue"));
            Destroy(GameObject.Find("white"));
            Destroy(GameObject.Find("red"));
            Destroy(GameObject.Find("purple"));
            Destroy(GameObject.Find("grey"));
            GameObject x = GameObject.Find("Final");
            ibtn = x.GetComponent<Image>();
            ibtn.GetComponent<Image>().sprite = Booksexpan;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
