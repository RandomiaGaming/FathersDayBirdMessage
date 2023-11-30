using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour {
    public float xpos;
    public float ypos;
    public bool hit = false;

    // Use this for initialization
    void Start() {
        xpos = transform.position.x;
        ypos = transform.position.y;
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!hit)
        {
            hit = true;
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-200f, 0f));
        }
    }
	// Update is called once per frame
	void Update () {
        if (!hit)
        {
            GetComponent<Rigidbody2D>().gravityScale = 0f;
            if (xpos > 30f)
            {
                transform.position = new Vector2(-30f, ypos);
                xpos = transform.position.x;
            }
            else
            {
                xpos = xpos + 0.1f;
                transform.position = new Vector2(xpos, ypos);
            }
        }else
        {
           
            GetComponent<Rigidbody2D>().gravityScale = 1f;
            
        }
	}
}
