using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ButtonGlobal : MonoBehaviour {
    public GameObject globalUISounds;
    GameObject MyUISounds;
    public GameObject btnObj;
    Button btn;
    // Use this for initialization
    void Start()
    {
        btn = btnObj.GetComponent<Button>();
        btn.onClick.AddListener(delegate ()
        {
            MyUISounds = GameObject.FindGameObjectWithTag("GlobalUISounds");
            if (MyUISounds == null)
                MyUISounds = (GameObject)Instantiate(globalUISounds);
        });
    }

    // Update is called once per frame
    void Update()
    {

    }
}
