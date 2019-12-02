using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Exit : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(OnClick);

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnClick()
    {
        PlayerPrefs.SetString("Previousclick", "");
        Application.Quit();
    }
}
