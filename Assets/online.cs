using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class online : MonoBehaviour {

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
          
                Application.OpenURL("file:///C:/Users/Jack/Desktop/index.html");
           
        }
    }
}
