using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using UnityEngine;
using System.Collections;

public class Door_movie : MonoBehaviour
{
    // 声明用于获取视频纹理的MovieTexture字段Movie.
    public MovieTexture Movie = null;
    // 声明用于获取视频的音频剪辑的AudioSource.  
    private AudioSource audios;
    void Start()
    {
        // 获取PLane对象的MeshRenderer组件.
        MeshRenderer meshrenderer = GetComponent<MeshRenderer>();
        // 将MeshRenderer组件的纹理材质替换为MovieTexture类型的视频.
        meshrenderer.material.mainTexture = Movie;
        audios = GetComponent<AudioSource>();
        // 将MovieTexture的音频剪辑赋值给Audio Source组件的clip
        //audios.clip = Movie.AudioClip;
        //audio.spatialBlend = 0;
        Movie.Play();
    }  

    void OnGUI()

    {

                //mTexture.Play();

    }

}