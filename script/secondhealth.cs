﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class secondhealth : MonoBehaviour
{
    public Text health;
    public GameObject player;

    // Start is called before the first frame update

    public int maxhealth = 90;




    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        if(maxhealth <= 0)
        {
                SceneManager.LoadScene("Death");
            
        }
        health.text = maxhealth.ToString();

       
    }
}
