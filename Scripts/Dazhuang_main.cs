using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Dazhuang_main : MonoBehaviour
{
    public GameObject btnObj;
    public Sprite Gridback,Bushuang, Dazhuangnokey;
    public Font fff;
    Button btn;
    public AudioSource trade,source;
    int count = 0;
    string[] sentences= { "","","",""},ss= { "","",""},bes= {"","" };
    GameObject x;
    string traded="";
    void Start()
    {
        x = GameObject.Find("words");
        sentences[0] = "\"Thanks for demon's immeasurable generosity, you already have the key to leave\"";
        sentences[1] = "*evil laugh*";
        sentences[2] = "\"You think you are innocent? Come on, you were even more like a devil than me when you chose to give up your life\"";
        ss[0] = "Never try to cheat a demon, you greedy blighter. Your life worth more\"";
        ss[1] = "Is this all you have in your life? Oh, what a pitiful wretch\"";
        ss[2] = "Demon makes only equivalent exchange. Don't let me say it again\"";
        bes[0]= "*evil laugh*";
        bes[1] = "\"GOOD LUCK\"";
        btn = btnObj.GetComponent<Button>();
        btn.onClick.AddListener(delegate ()
        {
            traded = "";
            x.GetComponent<Text>().font = fff;
            x.GetComponent<Text>().fontSize = 50;
            if (PlayerPrefs.GetInt("getBkey") == 0)
            {
                source.Play();
                GameObject.Find("words").GetComponent<Text>().text = "\"This gift's for you\"";
                ItemManager.Instance.StoreItem(21);
                this.GetComponent<Image>().sprite = Dazhuangnokey;
                PlayerPrefs.SetInt("getBkey", 1);
            }
            else if (PlayerPrefs.GetInt("HEkey") == 0 && PlayerPrefs.GetString("21") == "off" && PlayerPrefs.GetInt("BE") == 0)
            {
                if (PlayerPrefs.GetInt("photo") == 1)
                {
                    PlayerPrefs.SetInt("Tradecount", PlayerPrefs.GetInt("Tradecount", 0) + 1);
                    GameObject item = GameObject.Find("photo");
                    Destroy(item);
                    PlayerPrefs.SetString("4", "on");
                    GameObject[] temp;
                    temp = GameObject.FindGameObjectsWithTag("Grid");
                    PlayerPrefs.SetInt("photo", 0);
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
                    if (PlayerPrefs.GetInt("HEkey") == 0
                        && PlayerPrefs.GetString("4") == "on"
                        && PlayerPrefs.GetString("6") == "on"
                        && PlayerPrefs.GetString("8") == "on"
                         && PlayerPrefs.GetString("11") == "on"
                         && PlayerPrefs.GetString("15") == "on")
                    {
                        source.Play();
                        PlayerPrefs.SetInt("HEkey", 1);
                        ItemManager.Instance.StoreItem(22);
                        GameObject.Find("Demon").GetComponent<Image>().sprite = Bushuang;
                        GameObject.Find("words").GetComponent<Text>().text = "\"Now you deserve this\"";
                        Destroy(GameObject.Find("trade"));
                    }
                    else
                    {
                        trade.Play();
                        GameObject.Find("words").GetComponent<Text>().text = "\"Juicy tragedy, What a appetizing dish\"";
                    }
                }
                else if (PlayerPrefs.GetInt("newspaper") == 1)
                {
                    PlayerPrefs.SetInt("Tradecount", PlayerPrefs.GetInt("Tradecount", 0) + 1);
                    GameObject item = GameObject.Find("newspaper");
                    Destroy(item);
                    PlayerPrefs.SetString("6", "on");
                    GameObject[] temp;
                    temp = GameObject.FindGameObjectsWithTag("Grid");
                    PlayerPrefs.SetInt("newspaper", 0);
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
                    if (PlayerPrefs.GetInt("HEkey") == 0
                        && PlayerPrefs.GetString("4") == "on"
                        && PlayerPrefs.GetString("6") == "on"
                        && PlayerPrefs.GetString("8") == "on"
                         && PlayerPrefs.GetString("11") == "on"
                         && PlayerPrefs.GetString("15") == "on")
                    {
                        source.Play();
                        PlayerPrefs.SetInt("HEkey", 1);
                        ItemManager.Instance.StoreItem(22);
                        GameObject.Find("Demon").GetComponent<Image>().sprite = Bushuang;
                        GameObject.Find("words").GetComponent<Text>().text = "\"Now you deserve this\"";
                        Destroy(GameObject.Find("trade"));
                    }
                    else
                    {
                        trade.Play();
                        GameObject.Find("words").GetComponent<Text>().text = "\"The glory, I won't say it is futile\"";
                    }
                }
                else if (PlayerPrefs.GetInt("amulet") == 1)
                {
                    PlayerPrefs.SetInt("Tradecount", PlayerPrefs.GetInt("Tradecount", 0) + 1);
                    GameObject item = GameObject.Find("amulet");
                    Destroy(item);
                    PlayerPrefs.SetString("8", "on");
                    GameObject[] temp;
                    temp = GameObject.FindGameObjectsWithTag("Grid");
                    PlayerPrefs.SetInt("amulet", 0);
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
                    if (PlayerPrefs.GetInt("HEkey") == 0
    && PlayerPrefs.GetString("4") == "on"
    && PlayerPrefs.GetString("6") == "on"
    && PlayerPrefs.GetString("8") == "on"
     && PlayerPrefs.GetString("11") == "on"
     && PlayerPrefs.GetString("15") == "on")
                    {
                        source.Play();
                        PlayerPrefs.SetInt("HEkey", 1);
                        ItemManager.Instance.StoreItem(22);
                        GameObject.Find("Demon").GetComponent<Image>().sprite = Bushuang;
                        GameObject.Find("words").GetComponent<Text>().text = "\"Now you deserve this\"";
                        Destroy(GameObject.Find("trade"));
                    }
                    else
                    {
                        GameObject.Find("words").GetComponent<Text>().text = "\"Fortune, it's not bad\"";
                        trade.Play();
                    }
                }
                else if (PlayerPrefs.GetInt("coin") == 1)
                {
                    PlayerPrefs.SetInt("Tradecount", PlayerPrefs.GetInt("Tradecount", 0) + 1);
                    GameObject item = GameObject.Find("coin");
                    Destroy(item);
                    PlayerPrefs.SetString("11", "on");
                    GameObject[] temp;
                    temp = GameObject.FindGameObjectsWithTag("Grid");
                    PlayerPrefs.SetInt("coin", 0);
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
                    if (PlayerPrefs.GetInt("HEkey") == 0
    && PlayerPrefs.GetString("4") == "on"
    && PlayerPrefs.GetString("6") == "on"
    && PlayerPrefs.GetString("8") == "on"
     && PlayerPrefs.GetString("11") == "on"
     && PlayerPrefs.GetString("15") == "on")
                    {
                        source.Play();
                        PlayerPrefs.SetInt("HEkey", 1);
                        ItemManager.Instance.StoreItem(22);
                        GameObject.Find("Demon").GetComponent<Image>().sprite = Bushuang;
                        GameObject.Find("words").GetComponent<Text>().text = "\"Now you deserve this\"";
                        Destroy(GameObject.Find("trade"));
                    }
                    else
                    {
                        GameObject.Find("words").GetComponent<Text>().text = "\"Wealth, oh yes, quite a lot\"";
                        trade.Play();
                    }
                }
                else if (PlayerPrefs.GetInt("letter") == 1)
                {
                    PlayerPrefs.SetInt("Tradecount", PlayerPrefs.GetInt("Tradecount", 0) + 1);
                    GameObject item = GameObject.Find("letter");
                    Destroy(item);
                    PlayerPrefs.SetString("15", "on");
                    GameObject[] temp;
                    temp = GameObject.FindGameObjectsWithTag("Grid");
                    PlayerPrefs.SetInt("letter", 0);
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
                    if (PlayerPrefs.GetInt("HEkey") == 0
    && PlayerPrefs.GetString("4") == "on"
    && PlayerPrefs.GetString("6") == "on"
    && PlayerPrefs.GetString("8") == "on"
     && PlayerPrefs.GetString("11") == "on"
     && PlayerPrefs.GetString("15") == "on")
                    {
                        source.Play();
                        PlayerPrefs.SetInt("HEkey", 1);
                        ItemManager.Instance.StoreItem(22);
                        GameObject.Find("Demon").GetComponent<Image>().sprite = Bushuang;
                        GameObject.Find("words").GetComponent<Text>().text = "\"Now you deserve this\"";
                        Destroy(GameObject.Find("trade"));
                    }
                    else
                    {
                        GameObject.Find("words").GetComponent<Text>().text = "\"Cloying love... but I don't hate it\"";
                        trade.Play();
                    }
                }
                else if (PlayerPrefs.GetInt("HEkey") == 0)
                {
                    if (PlayerPrefs.GetInt("Tradecount", 0) > 0)
                        count = Random.Range(0, 5);
                    else
                        count = Random.Range(0, 3);
                    if (count <= 2)
                        GameObject.Find("words").GetComponent<Text>().text = sentences[count];
                    else
                    {
                        if (PlayerPrefs.GetString("4") == "on")
                        {
                            traded += "Past...";
                        }
                        if (PlayerPrefs.GetString("6") == "on")
                        {
                            traded += "Glory...";
                        }
                        if (PlayerPrefs.GetString("8") == "on")
                        {
                            traded += "Fortune...";
                        }
                        if (PlayerPrefs.GetString("11") == "on")
                        {
                            traded += "Wealth...";
                        }
                        if (PlayerPrefs.GetString("15") == "on")
                        {
                            traded += "Love...";
                        }

                        GameObject.Find("words").GetComponent<Text>().text = "\"" + traded + ss[Random.Range(0, 3)];
                    }

                }

            }
            else if ((PlayerPrefs.GetInt("HEkey") == 1 || PlayerPrefs.GetInt("HE") == 1) && PlayerPrefs.GetInt("BE") == 0)
            {
                GameObject.Find("words").GetComponent<Text>().text = sentences[1];
            }
            else if (PlayerPrefs.GetInt("BE") == 1)
            {
                GameObject.Find("words").GetComponent<Text>().text = bes[Random.Range(0, 2)];
            }
        });
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
        {
            x.GetComponent<Text>().font = Resources.Load<Font>("Fonts/octin");
            x.GetComponent<Text>().fontSize = 40;
            //x.GetComponent<Text>().text = "";
        }
    }
}