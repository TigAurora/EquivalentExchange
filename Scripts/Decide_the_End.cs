using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Decide_the_End : MonoBehaviour
{
    public GameObject btnObj;
    public Sprite BE, HE, Gridback;
    Button btn;
    public AudioSource source;
    GameObject x;
    void Start()
    {
        btn = btnObj.GetComponent<Button>();
        btn.onClick.AddListener(delegate ()
        {
            if ((PlayerPrefs.GetInt("blackkey") == 1) && PlayerPrefs.GetInt("Door_exit")==1 && PlayerPrefs.GetInt("HE") == 0)
            {
                source.Play();
                Invoke("BEstuff", 0.5f);
            }
            if ((PlayerPrefs.GetInt("goldenkey") == 1) && PlayerPrefs.GetInt("Door_exit") == 1 && PlayerPrefs.GetInt("BE") == 0)
            {
                source.Play();
                Invoke("HEstuff", 0.5f);
            }
        });
    }
    void Update()
    {
    }
    void BEstuff()
    {
        GameObject s = GameObject.Find("Door");
        foreach (Transform child in s.transform)
        {
            if (child.name == "BEImage" || child.name == "BEPlayer")
            {
                child.gameObject.SetActive(true);
            }
        }
        Invoke("BEstuff2", 2f);
        GameObject[] item = GameObject.FindGameObjectsWithTag("CollectedItem");
        for (int i = 0; i < item.Length; ++i)
        {
            if (item[i].name == "blackkey")
            {
                Destroy(item[i]);
                break;
            }
        }
        PlayerPrefs.SetString("21", "on");
        GameObject[] temp;
        temp = GameObject.FindGameObjectsWithTag("Grid");
        PlayerPrefs.SetInt("blackkey", 0);
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
    void HEstuff()
    {
        GameObject s = GameObject.Find("Door");
        foreach (Transform child in s.transform)
        {
            if (child.name == "RawImage" || child.name == "HEPlayer")
            {
                child.gameObject.SetActive(true);
            }
        }
        Invoke("HEstuff2",2f);
        GameObject[] item = GameObject.FindGameObjectsWithTag("CollectedItem");
        for (int i = 0; i < item.Length; ++i)
        {
            if (item[i].name == "goldenkey")
            {
                Destroy(item[i]);
                break;
            }
        }
        PlayerPrefs.SetString("23", "on");
        GameObject[] temp;
        temp = GameObject.FindGameObjectsWithTag("Grid");
        PlayerPrefs.SetInt("goldenkey", 0);
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
    void BEstuff2()
    {
        GameObject s = GameObject.Find("Door");
        s.GetComponent<Image>().sprite = BE;
        PlayerPrefs.SetInt("BE", 1);
    }
    void HEstuff2()
    {
        GameObject s = GameObject.Find("Door");
        s.GetComponent<Image>().sprite = HE;
        PlayerPrefs.SetInt("HE", 1);
    }
}