using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DoorHealth : MonoBehaviour
{

    public Text health;
    public GameObject player;

    // Start is called before the first frame update

    public int maxhealth = 100;




    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {

        health.text = maxhealth.ToString();

        if (maxhealth <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }


}

