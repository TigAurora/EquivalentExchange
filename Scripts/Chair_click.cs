using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections.Generic;

public class Chair_click : MonoBehaviour
{
    Button btn;
    public Sprite Chairexpan;
    public GameObject btnObj;
    //string place;
    void Start()
    {
        btn = btnObj.GetComponent<Button>();
        btn.onClick.AddListener(delegate ()
        {
            PlayerPrefs.SetInt("Chair_click", 1);
            GameObject chair2 = GameObject.Find("chair2");
            chair2 = GameObject.Find("chair2");
            chair2.GetComponent<Image>().sprite = Chairexpan;
            chair2.GetComponent<Image>().raycastTarget = true;
            Destroy(this.gameObject);

        });
    }

}
