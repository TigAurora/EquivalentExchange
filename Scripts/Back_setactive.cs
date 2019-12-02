using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using System.Collections;
using System;
using UnityEngine.SceneManagement;

public class Back_setactive : MonoBehaviour
{

    public GameObject btnObj;
    public Sprite Gridback, nonepng,under;
    //public AudioSource source;
    Button btn;
    public AudioSource source;
    GameObject s;
    // Use this for initialization
    void Start()
    {
        btn = btnObj.GetComponent<Button>();
        btn.onClick.AddListener(delegate ()
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null)
            {
                if (hit.transform.name == "Back")
                {
                    s = GameObject.Find("Pick_audio");
                    PlayerPrefs.SetInt("Rightclick", 0);
                    PlayerPrefs.SetString("Previousclick","");
                    if (SceneManager.GetActiveScene().name == "Room1_West" && PlayerPrefs.GetInt("Demon") == 1)
                    {
                        GameObject.Find("under").GetComponent<Image>().sprite = under;
                        GameObject.Find("under1").GetComponent<Image>().sprite = nonepng;
                    }
                    //print("back");
                    //GameObject.FindGameObjectWithTag("pickaudio").gameObject.SetActive(true);
                    GameObject.Find("words").GetComponent<Text>().text = "";
                    if (PlayerPrefs.GetInt("GetFlower") == 1 && PlayerPrefs.GetInt("id18")==0)
                    {
                        s.GetComponent<AudioSource>().Play();
                        PlayerPrefs.SetInt("GET",1);
                        ItemManager.Instance.StoreItem(18);
                        GameObject[] item = GameObject.FindGameObjectsWithTag("CollectedItem");
                        for (int i = 0; i < item.Length; ++i)
                        {
                            if (item[i].name == "soil")
                            {
                                Destroy(item[i].gameObject);
                                break;
                            }
                        }
                        PlayerPrefs.SetString("17", "on");
                        GameObject[] temp;
                        temp = GameObject.FindGameObjectsWithTag("Grid");
                        PlayerPrefs.SetInt("soil", 0);
                        PlayerPrefs.SetInt("TotalGrid", PlayerPrefs.GetInt("TotalGrid") - 1);
                        foreach (GameObject grids in temp)
                        {
                            if (PlayerPrefs.GetInt(grids.name) == 1)
                            {
                                PlayerPrefs.SetInt(grids.name, 0);
                                grids.GetComponent<Image>().sprite = Gridback;
                                // break;
                            }
                        }
                        PlayerPrefs.SetInt("GetFlower", 0);
                    }
                    if (PlayerPrefs.GetInt("GetPlug") == 1 && PlayerPrefs.GetInt("id20") == 0)
                    {
                        s.GetComponent<AudioSource>().Play();
                        PlayerPrefs.SetInt("GET", 1);
                        ItemManager.Instance.StoreItem(20);
                        GameObject[] item = GameObject.FindGameObjectsWithTag("CollectedItem");
                        for (int i = 0; i < item.Length; ++i)
                        {
                            if (item[i].name == "plug")
                            {
                                Destroy(item[i].gameObject);
                                break;
                            }
                        }
                        PlayerPrefs.SetString("10", "on");
                        GameObject[] temp;
                        temp = GameObject.FindGameObjectsWithTag("Grid");
                        PlayerPrefs.SetInt("plug", 0);
                        PlayerPrefs.SetInt("TotalGrid", PlayerPrefs.GetInt("TotalGrid") - 1);
                        foreach (GameObject grids in temp)
                        {
                            if (PlayerPrefs.GetInt(grids.name) == 1)
                            {
                                PlayerPrefs.SetInt(grids.name, 0);
                                grids.GetComponent<Image>().sprite = Gridback;
                                // break;
                            }
                        }
                        PlayerPrefs.SetInt("GetPlug", 0);
                    }
                    foreach (Transform child in this.transform)
                    {
                        if (child.name != "Back")
                            child.gameObject.SetActive(false);
                    }
                    this.gameObject.SetActive(false);
                }
            }
        });
    }


    // Update is called once per frame
    void Update()
    {

    }
    void Destroythis()
    {
        this.gameObject.SetActive(false);
    }
}
