using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class Beginning_movie : MonoBehaviour
{

    void Start()
    {
        PlayerPrefs.SetInt("played", 0);
        this.GetComponent<VideoPlayer>().SetDirectAudioVolume(0, 0.301f);
        if (PlayerPrefs.GetInt("S5kip", 0) == 1)
        {
            print("here");
            SceneManager.LoadScene("Menu");
        }
    }
    void Update()
    {
        if (this.GetComponent<VideoPlayer>().isPlaying)
        {
            PlayerPrefs.SetInt("played", 1);
        }
        if ((this.GetComponent<VideoPlayer>().isPlaying && (Input.GetKey(KeyCode.Escape) || Input.GetKey(KeyCode.Space)))|| (!this.GetComponent<VideoPlayer>().isPlaying&& PlayerPrefs.GetInt("played",0)==1))
        {
            this.GetComponent<VideoPlayer>().Stop();
            Invoke("jump", 1f);
        }
    }
    void jump()
    {
        SceneManager.LoadScene("Menu");
    }

}