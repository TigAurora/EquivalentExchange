using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class Begin_movie_delete : MonoBehaviour
{

    void Start()
    {
        
    }
    void Update()
    {
        if (this.GetComponent<VideoPlayer>().isPlaying && (Input.GetKey(KeyCode.Escape) || Input.GetKey(KeyCode.Space)))
        {

            SceneManager.LoadScene("Room1_West");
        }
        if (!this.GetComponent<VideoPlayer>().isPlaying)
        {

            SceneManager.LoadScene("Room1_West");
        }
    }

}