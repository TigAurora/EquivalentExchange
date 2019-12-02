using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Arrange : MonoBehaviour
{
    private Dictionary<int, Book> itemList;
    //private Dictionary<string, float> arrange;
    public Sprite b, w, r,p,g;
    float bl, wh, re, pu, gr;
    public AudioSource source,dragsource;
    public Sprite Booksexpan;
    Image ibtn;
    // Use this for initialization
    void Start()
    {
        PlayerPrefs.SetString("Drag", "off");
    }
    void Awake()
    {

        this.LoadData();

    }
    // Update is called once per frame
    void Update()
    {
        Arrangeorder();
        if (PlayerPrefs.GetString("Drag") == "on")
        {
            dragsource.Play();
            Resetposition();
            Welldone();
            PlayerPrefs.SetString("Drag", "off");
        }
    }
    private void Arrangeorder()
    {
        Book temp;
        foreach (KeyValuePair<int,Book> item in itemList)
        {
            item.Value.x = GameObject.Find(item.Value.name).transform.position.x;
        }


        for (int i = 1; i <= 5; ++i)
        {
            for (int j = i+1; j <= 5; ++j)
            {
                if (itemList[j].x < itemList[i].x)
                {
                    temp = itemList[j];
                    itemList[j] = itemList[i];
                    itemList[i] = temp;
                }
            }
            print(itemList[i]);
        }
    }
    private void Resetposition()
    {
        GameObject book;
        float currentpos = -641;
        for (int i = 1; i <= 5; ++i)
        {
            book = GameObject.Find(itemList[i].name);
            Vector3 tempx = book.transform.position;
            tempx.x = currentpos + itemList[i].w / 2;
            book.transform.position = tempx;
            currentpos += itemList[i].w;
        }
        //print("here");
    }
    private void Welldone()
    {
        if (itemList[1].name == "red" && itemList[2].name == "grey" && itemList[3].name == "blue"
            && itemList[4].name == "white" && itemList[5].name == "purple")
        {
            source.Play();
            for (int i=1;i<=5;++i)
                Destroy(GameObject.Find(itemList[i].name));
            PlayerPrefs.SetString("CabLight","on");
            GameObject x = GameObject.Find("Final");
            ibtn = x.GetComponent<Image>();
            ibtn.GetComponent<Image>().sprite = Booksexpan;
            Destroy(this.GetComponent("Arrange"));
        }
    }
    private void LoadData()
    {

        itemList = new Dictionary<int, Book>();
        //float he = -247.5f;
        Book blue = new Book(481, 178, "blue",-533, -9);
        Book white = new Book(388, 63, "white", 209.5f, -55.5f);
        Book red = new Book( 624, 74, "red", 278, 62.5f);
        Book purple = new Book(512, 153, "purple", 391.5f, 6.5f);
        Book grey = new Book(259, 75, "grey", 504.5f, -120);

        itemList.Add(1, blue);
        itemList.Add(2, white);
        itemList.Add(3, red);
        itemList.Add(4, purple);
        itemList.Add(5, grey);
    }
}
