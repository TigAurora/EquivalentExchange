using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book {

    public int h;
    public int w;
    //public int order { get; private set; }
    public string name;
    public float x;
    public float y;
    //public Sprite icon;

    public Book(int h, int w, string name, float posx, float posy)
    {
        this.h = h;
        this.w = w;
        this.x = x;
        this.y = y;
        //this.order = order;
        this.name = name;
        //this.icon = icon;

    }
}
