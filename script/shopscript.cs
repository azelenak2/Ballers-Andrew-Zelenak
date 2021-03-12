using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopscript : MonoBehaviour
{
    public string dragkey = "DragandDrop";

    bool isdraggin = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis(dragkey) > 0)
        {
            
        }
    }
}
