using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GotoBedcloser : MonoBehaviour
{
    public AudioSource source;
    // Use this for initialization
    void Start()
    {
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
    }
    void Update()
    {

    }
    // Update is called once per frame
    void OnClick()
    {
        source.Play();
        GameObject scroll = GameObject.Find("Scrollbar");
        if (scroll != null)
            PlayerPrefs.SetFloat("scrollvalue", scroll.GetComponent<Scrollbar>().value);
        SceneManager.LoadScene("Bed_closer");
    }
}
