using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Healthplayer : MonoBehaviour
{
    public Text healthf;
    public secondhealth eal;
    

    // Start is called before the first frame update

    public int maxhealth = 100;




    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        

        healthf.text = maxhealth.ToString();

        if (maxhealth <= 0)
        {
            SceneManager.LoadScene(2);
        }

        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            eal.maxhealth --;
        }
    }
}
