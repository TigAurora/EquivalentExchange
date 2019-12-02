using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Get_greenkey : MonoBehaviour
{
    public GameObject btnObj;
    public Sprite Gridback;
    Button btn;
    public AudioSource source;
    void Start()
    {
        btn = btnObj.GetComponent<Button>();
        btn.onClick.AddListener(delegate ()
        {
            if (PlayerPrefs.GetInt("minutehand") == 1)
            {
                source.Play();
                GameObject.Find("words").GetComponent<Text>().text = "A green key";
                ItemManager.Instance.StoreItem(19);
                GameObject item = GameObject.Find("minutehand");
                Destroy(item);
                PlayerPrefs.SetString("2", "on");
                GameObject[] temp;
                temp = GameObject.FindGameObjectsWithTag("Grid");
                PlayerPrefs.SetInt("minutehand", 0);
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
                Destroy(this.gameObject);
            }
            else
            {
                GameObject.Find("words").GetComponent<Text>().text = "I can't reach it";
            }
        });
    }

}