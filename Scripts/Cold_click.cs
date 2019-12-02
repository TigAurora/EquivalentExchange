using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Cold_click : MonoBehaviour
{
    public GameObject btnObj;
    public Sprite expan;
    public Sprite back;
    public Sprite coldwater, Nonepng;
    Button btn;
    public int flag = 0;
    public AudioSource Water, tapopen, tapclose;
    void Start()
    {
            btn = btnObj.GetComponent<Button>();
            btn.onClick.AddListener(delegate ()
            {
                GameObject w = GameObject.Find("water");
                if (PlayerPrefs.GetInt("coldwater") == 0)
                {
                    tapopen.Play();
                    if (PlayerPrefs.GetInt("Waterplay", 0) == 0)
                    {
                        Water.Play();
                        PlayerPrefs.SetInt("Waterplay", 1);
                    }
                    btn.GetComponent<Image>().sprite = expan;
                    PlayerPrefs.SetInt("coldwater",1);
                    w.GetComponent<Image>().sprite = coldwater;
                }
                else
                {
                    btn.GetComponent<Image>().sprite = back;
                    PlayerPrefs.SetInt("coldwater", 0);
                    tapopen.Play();
                    if (PlayerPrefs.GetInt("hotwater") == 0)
                    {
                        w.GetComponent<Image>().sprite = Nonepng;
                        PlayerPrefs.SetInt("Waterplay", 0);
                        Water.Stop();
                        tapclose.Play();
                    }

                }
            });
        }
    }