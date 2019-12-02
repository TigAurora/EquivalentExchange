using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroyMusic : MonoBehaviour {
    public Scene na;
	// Use this for initialization
	void Start () {
        na = SceneManager.GetActiveScene();
	}

    // Update is called once per frame
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    void Update() {
        if (SceneManager.GetActiveScene() != na)
        {
            if (this.gameObject.GetComponent<AudioSource>().isPlaying == false)
                Destroy(this.gameObject);
        }
    }

    void destroythis()
    {
        if (this.gameObject.GetComponent<AudioSource>().isPlaying == false)
            Destroy(this.gameObject);
    }
}
