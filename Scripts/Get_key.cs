using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Get_key : MonoBehaviour
{
    public GameObject btnObj;
    public Sprite Keyexpan, Gridback,none;
    Button btn;
    public AudioSource source;
    //public AudioSource source;
    void Start()
    {
        btn = btnObj.GetComponent<Button>();
        btn.onClick.AddListener(delegate ()
        {
            //GameObject.FindGameObjectWithTag("pickaudio").gameObject.SetActive(true);
            if (PlayerPrefs.GetInt("id23", 0) == 0 && PlayerPrefs.GetInt("blackkey") == 1)
            {
                source.Play();
                ItemManager.Instance.StoreItem(23);
                GameObject.Find("words").GetComponent<Text>().text = "A golden key";
                GameObject s = GameObject.FindWithTag("heart");
                s.GetComponent<Image>().sprite = Keyexpan;
                this.GetComponent<Image>().sprite = none;
                GameObject.Find("Heart_audio").SetActive(false);
                PlayerPrefs.SetInt("blackkey", 0);
                //PlayerPrefs.SetInt("GetKey", 1);
                GameObject[] item = GameObject.FindGameObjectsWithTag("CollectedItem");
                for (int i = 0; i < item.Length; ++i)
                {
                    if (item[i].name == "heart" || item[i].name == "blackkey")
                    {
                        Destroy(item[i]);
                    }
                }
                PlayerPrefs.SetString("22", "on");
                PlayerPrefs.SetString("21", "on");
                GameObject[] temp;
                temp = GameObject.FindGameObjectsWithTag("Grid");
                PlayerPrefs.SetInt("heart", 0);
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
                this.GetComponent<Get_key>().enabled = false;
                
            }
        });
    }
    void Update()
    {
        //Debug.Log("22222");
        //Debug.Log(PlayerPrefs.GetInt("knife"));

    }
}