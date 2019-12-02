using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class Door_movie_delete : MonoBehaviour
{

    void Start()
    {
        this.GetComponent<VideoPlayer>().SetDirectAudioVolume(0, 0.7f);
        PlayerPrefs.SetInt("endplayed", 0);
    }
    void Update()
    {
        if (this.GetComponent<VideoPlayer>().isPlaying)
            PlayerPrefs.SetInt("endplayed", 1);
        if (!this.GetComponent<VideoPlayer>().isPlaying && PlayerPrefs.GetInt("endplayed", 0) == 1)
        {
            Destroy(GameObject.Find("RawImage"));
            Destroy(GameObject.Find("BEImage"));
            Destroy(GameObject.Find("BEPlayer"));
            Destroy(GameObject.Find("HEPlayer"));
        }
    }

}