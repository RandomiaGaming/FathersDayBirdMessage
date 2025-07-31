using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class daddata : MonoBehaviour {

    public Sprite happytexture;
    public GameObject me;
    public GameObject happytxt;
    public float timer;

    void Start()
    {
        me = GameObject.Find("happy2");
        happytxt = GameObject.Find("happytxt");
        happytexture = happytxt.GetComponent<SpriteRenderer>().sprite;
    }

    void OnMouseOver()
    {
        timer = 10;
    }

    void Update()
    {
        if (timer > 1)
        {
            me.GetComponent<SpriteRenderer>().sprite = happytexture;
            timer--;
        }
        else if (timer == 1)
        {
            me.GetComponent<SpriteRenderer>().sprite = null;
        }

    }

}
