using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class health : MonoBehaviour
{
    public Healthplayer helth;
    public Text healthtext;
    public GameObject player;

    // Start is called before the first frame update

    public int maxhealth = 100;




    void Start()
    {



    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            helth.maxhealth -= 5;


        }




    }
}
