using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GLO : MonoBehaviour
{

    public static GLO Instance;

    //要保存使用的数据;
    public int grid1;
    public int id1;
    public int TotalGrid;

    //初始化
    private void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != null)
        {
            Destroy(gameObject);
        }
    }
}