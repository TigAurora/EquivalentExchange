using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Broken_tub : MonoBehaviour
{
    public GameObject btnObj;
    Button btn;
    void Start()
    {
        btn = btnObj.GetComponent<Button>();
        btn.onClick.AddListener(delegate ()
        {
            GameObject.Find("words").GetComponent<Text>().text = "It's broken";
        });
    }

}