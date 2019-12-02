using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Get_plug : MonoBehaviour
{
    public GameObject btnObj;
    public Sprite Plugexpan,Nonepng, Gridback;
    Button btn;
    //public AudioSource source;
    void Start()
    {
        btn = btnObj.GetComponent<Button>();
        btn.onClick.AddListener(delegate ()
        {
            if ((PlayerPrefs.GetInt("cable") == 1))
            {
                //GameObject.FindGameObjectWithTag("pickaudio").gameObject.SetActive(true);
                //source.Play();
                GameObject.Find("words").GetComponent<Text>().text = "A plug with cable";
                GameObject s = GameObject.FindWithTag("plugwithcable");
                s.GetComponent<Image>().sprite = Plugexpan;
                s = GameObject.FindWithTag("plug");
                s.GetComponent<Image>().sprite = Nonepng;
                PlayerPrefs.SetInt("GetPlug", 1);
                GameObject[] item = GameObject.FindGameObjectsWithTag("CollectedItem");
                for (int i = 0; i < item.Length; ++i)
                {
                    if (item[i].name == "cable")
                    {
                        Destroy(item[i]);
                    }
                }
                PlayerPrefs.SetString("14", "on");
                GameObject[] temp;
                temp = GameObject.FindGameObjectsWithTag("Grid");
                PlayerPrefs.SetInt("cable", 0);
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
        });
    }
    void Update()
    {
        //Debug.Log("22222");
        //Debug.Log(PlayerPrefs.GetInt("knife"));

    }
}