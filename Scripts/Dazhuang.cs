using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dazhuang : MonoBehaviour
{
    public Sprite under;
    public Sprite above;
    public Sprite demon, Dazhuangnokey,Bushuang,Nonepng;
    void Start()
    {

            if (PlayerPrefs.GetInt("Demon") == 1)
            {
                GameObject.Find("under").GetComponent<Image>().sprite = under;
                if (SceneManager.GetActiveScene().name == "Room1_West")
                {
                    if (PlayerPrefs.GetInt("id22") == 1)
                    {
                        GameObject s = GameObject.Find("Demon");
                        s.GetComponent<Image>().sprite = Bushuang;
                        Destroy(GameObject.Find("trade"));
                    }
                    else if (PlayerPrefs.GetInt("getBkey") == 1)
                            {
                                GameObject temp = GameObject.Find("Demon");
                                temp.GetComponent<Image>().sprite = Dazhuangnokey;
                            }
                    else
                            GameObject.Find("Demon").GetComponent<Image>().sprite = demon;
                        GameObject.Find("Demon").GetComponent<Image>().raycastTarget = true;
                        GameObject.Find("Demon").GetComponent<BoxCollider2D>().enabled = true;
                        GameObject.Find("above").GetComponent<Image>().sprite = above;

                }
            }
     }
    void Update()
    {

    }
}