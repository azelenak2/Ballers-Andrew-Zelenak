using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cashmoney : MonoBehaviour
{
    public static float dacash;

    public int chumchange = 600;
  
   
    private void Start()
    {
        dacash = chumchange;
    }

     void Update()
    {
        dacash += Time.deltaTime;
       
        
    }
}
