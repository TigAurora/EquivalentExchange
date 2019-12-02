﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


//状态效果值
public enum FadeStatuss
{
    FadeIn,
    FadeOut
}

public class Fade_Control : MonoBehaviour
{
    //设置的图片
    public Image m_Sprite;
    //透明值
    private float m_Alpha;
    //淡入淡出状态
    private FadeStatuss m_Statuss;
    //效果更新的速度
    public float m_UpdateTime;
    //场景名称
    public string m_ScenesName;

    // Use this for initialization
    void Start()
    {
        //默认设置为淡入效果
        m_Statuss = FadeStatuss.FadeIn;
    }

    // Update is called once per frame
    void Update()
    {
        //控制透明值变化
        if (m_Statuss == FadeStatuss.FadeIn)
        {
            m_Alpha += m_UpdateTime * Time.deltaTime;
        }
        //else if (m_Statuss == FadeStatuss.FadeOut)
        //{
           // m_Alpha -= m_UpdateTime * Time.deltaTime;
        //}
        UpdateColorAlpha();
    }

    void UpdateColorAlpha()
    {
        //获取到图片的透明值
        Color ss = m_Sprite.color;
        ss.a = m_Alpha;
        //将更改过透明值的颜色赋值给图片
        m_Sprite.color = ss;
        //透明值等于的1的时候 转换成淡出效果
        if (m_Alpha > 1f)
        {
            m_Alpha = 1f;
            Invoke("Jump", 1.0f);
            //m_Statuss = FadeStatuss.FadeOut;
        }
        //值为0的时候跳转场景
        //else if (m_Alpha < 0)
       // {
            
        //}
    }
    void Jump()
    {
        if(PlayerPrefs.GetInt("BE")==1)
            SceneManager.LoadScene("BE");
        else if (PlayerPrefs.GetInt("HE") == 1)
            SceneManager.LoadScene("HE");
    }
}