using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class Begin_jump : MonoBehaviour
{

    void Start()
    {
        this.GetComponent<VideoPlayer>().Stop();
        if (PlayerPrefs.GetInt("Skip3", 0) == 1)
        {
            SceneManager.LoadScene("Menu");
        }
        else
            SceneManager.LoadScene("Beginning");
    }

}