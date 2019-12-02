using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoEast : MonoBehaviour
{
    public AudioSource source;
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
        source.Play();
        GameObject scroll = GameObject.Find("Scrollbar");
        if (scroll != null)
            PlayerPrefs.SetFloat("scrollvalue", scroll.GetComponent<Scrollbar>().value);
        SceneManager.LoadScene("Room1_East");
    }
}
