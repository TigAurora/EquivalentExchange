using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Get_flower : MonoBehaviour
{
    public GameObject btnObj;
    public Sprite Flowerexpan, Gridback,Soilexpan;
    Button btn;
    public AudioSource source,su;
    //public AudioSource source;
    void Start()
    {
        btn = btnObj.GetComponent<Button>();
        btn.onClick.AddListener(delegate ()
        {
            GameObject.Find("words").GetComponent<Text>().text = "I can plant something here";
            if ((PlayerPrefs.GetInt("seed") == 1) && PlayerPrefs.GetString("wetsoil") == "cold")
            {
                su.Play();
                //GameObject.FindGameObjectWithTag("pickaudio").gameObject.SetActive(true);
                GameObject.Find("words").GetComponent<Text>().text = "A hyacinth";
                GameObject s = GameObject.FindWithTag("soil");
                s.GetComponent<Image>().sprite = Flowerexpan;
                PlayerPrefs.SetInt("GetFlower", 1);
                GameObject[] item = GameObject.FindGameObjectsWithTag("CollectedItem");
                for (int i = 0; i < item.Length; ++i)
                {
                    if (item[i].name == "seed")
                    {
                        Destroy(item[i]);
                        break;
                    }
                }
                PlayerPrefs.SetString("16", "on");
                GameObject[] temp;
                temp = GameObject.FindGameObjectsWithTag("Grid");
                PlayerPrefs.SetInt("seed", 0);
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
            }
            else if ((PlayerPrefs.GetInt("seed") == 1) && PlayerPrefs.GetString("wetsoil") != "cold")
            {
                source.Play();
                GameObject.Find("words").GetComponent<Text>().text = "Nothing happens";
            }
        });
    }
    void Update()
    {
        if (PlayerPrefs.GetString("wetsoil","") == "" && PlayerPrefs.GetInt("GetFlower",0)!=1)
        {
            GameObject s = GameObject.FindWithTag("soil");
            s.GetComponent<Image>().sprite = Soilexpan;
        }
    }
}