using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EastMain : MonoBehaviour
{
    Image ibtn;
    public Sprite Booksexpan, Lightexpan,Safeexpan, Sofa1expan, Sofa2expan,Keyexpan, Nonepng,Barexpan,NoLetterexpan,lexpan,lback,rexpan,rback,wan;
    // Use this for initialization
    void Start()
    {
        if (PlayerPrefs.GetInt("Demon") == 1)
        {
            GameObject.Find("Room").GetComponent<Image>().sprite = wan;
        }
        //PlayerPrefs.SetInt("Cabbar", 0);
        //PlayerPrefs.SetInt("RCabflag", 0);
        if (PlayerPrefs.GetInt("RCabflag") == 1)
        {
            GameObject x = GameObject.Find("RightCab");
            x.gameObject.transform.localPosition = new Vector3(390, -107, 0F);
            GameObject.Find("LeftCab").transform.localPosition = new Vector3(342, -107, 0F);
            GameObject.Find("LeftCab").transform.GetComponent<Image>().sprite = lback;
            x.GetComponent<Image>().sprite = rexpan;
        }
        else if (PlayerPrefs.GetInt("Cabbar") == 1)
        {
            GameObject x = GameObject.Find("LeftCab");
            x.gameObject.transform.localPosition = new Vector3(498, -107, 0F);
            GameObject.Find("RightCab").transform.localPosition = new Vector3(559, -107, 0F);
            x.GetComponent<Image>().sprite = lexpan;
            GameObject.Find("RightCab").transform.GetComponent<Image>().sprite = rback;
        }

        if (PlayerPrefs.GetInt("sofatear") == 1)
        {
            if (PlayerPrefs.GetInt("id9",0) == 0)
            {
                GameObject x = GameObject.Find("Sofa_p3");
                ibtn = x.GetComponent<Image>();
                ibtn.GetComponent<Image>().sprite = Sofa1expan;
            }
            else if (PlayerPrefs.GetInt("id9") == 1)
            {
                GameObject x = GameObject.Find("Sofa_p3");
                ibtn = x.GetComponent<Image>();
                ibtn.GetComponent<Image>().sprite = Sofa2expan;
            }
        }
        if (PlayerPrefs.GetString("CabLight") == "on")
        {
            GameObject x = GameObject.Find("light");
            ibtn = x.GetComponent<Image>();
            ibtn.GetComponent<Image>().sprite = Lightexpan;
            x = GameObject.Find("Little_books");
            ibtn = x.GetComponent<Image>();
            ibtn.GetComponent<Image>().sprite = Booksexpan;
        }
        if (PlayerPrefs.GetString("19") == "on")
        {
            GameObject x = GameObject.Find("baffle");
            Destroy(x);
        }
        if (PlayerPrefs.GetInt("Safedone") == 1)
        {
            GameObject x = GameObject.Find("Go_Safe_Closer");
            GameObject y = GameObject.Find("code");
            Destroy(y);
            ibtn = x.GetComponent<Image>();
            ibtn.GetComponent<Image>().sprite = Safeexpan;
            x = GameObject.Find("knifekey");
            ibtn = x.GetComponent<Image>();
            ibtn.GetComponent<Image>().sprite = Keyexpan;
            if (PlayerPrefs.GetInt("Firstback", 0) == 0)
            {
                x = GameObject.Find("RightCab");
                x.gameObject.transform.localPosition = new Vector3(390, -107, 0F);
                GameObject.Find("LeftCab").transform.localPosition = new Vector3(342, -107, 0F);
                GameObject.Find("LeftCab").transform.GetComponent<Image>().sprite = lback;
                x.GetComponent<Image>().sprite = rexpan;
                PlayerPrefs.SetInt("Firstback", 1);
                PlayerPrefs.SetInt("RCabflag", 1);
                PlayerPrefs.SetInt("Cabbar", 0);
            }
        }
        if (PlayerPrefs.GetInt("id5") == 1)
        {
            Destroy(GameObject.Find("knifekey"));
        }
        if (PlayerPrefs.GetInt("id13") == 1)
        {
            Destroy(GameObject.Find("crowbar"));
        }
        if (PlayerPrefs.GetInt("id15") == 1)
        {
            GameObject.Find("Go_Letter_Closer").GetComponent<Image>().sprite = NoLetterexpan;
        }
       

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("Cabbar") == 0)
        {
            if (PlayerPrefs.GetInt("id13") == 0)
            {
                GameObject.Find("crowbar").GetComponent<Image>().sprite = Nonepng;
                GameObject.Find("crowbar").GetComponent<Image>().raycastTarget = false;
                GameObject.Find("crowbar").GetComponent<BoxCollider2D>().enabled = false;
            }
        }
        else
        {
            if (PlayerPrefs.GetInt("id13") == 0)
            {
                GameObject.Find("crowbar").GetComponent<Image>().sprite = Barexpan;
                GameObject.Find("crowbar").GetComponent<Image>().raycastTarget = true;
                GameObject.Find("crowbar").GetComponent<BoxCollider2D>().enabled = true;
            }
        }
        if (PlayerPrefs.GetInt("RCabflag") == 0)
        {
            if (PlayerPrefs.GetInt("id5") == 0)
            {
                GameObject.Find("knifekey").GetComponent<Image>().raycastTarget = false;
                GameObject.Find("knifekey").GetComponent<BoxCollider2D>().enabled = false;
            }
        }
        else
        {
            if (PlayerPrefs.GetInt("id5") == 0)
            {
                GameObject.Find("knifekey").GetComponent<Image>().raycastTarget = true;
                GameObject.Find("knifekey").GetComponent<BoxCollider2D>().enabled = true;
            }
        }

    }
}
