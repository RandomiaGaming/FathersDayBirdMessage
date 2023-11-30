using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tree : MonoBehaviour {
    public int timer;
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (timer < 1)
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 200f));
                timer = 60;
            }

        }
    }
  
    void Update()
    {
        timer--;
    }

}
