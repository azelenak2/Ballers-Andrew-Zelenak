using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHealth : MonoBehaviour
{
    public cashmoney point;
    public DoorHealth health;
    public int maxhealth = 100;
    public GameObject destroyimpact;
    public GameObject guy;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        

    }

    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "Bullet")
        {
            Destroy(guy);
            Destroy(gameObject);

            cashmoney.dacash += 50;

        }
    }

 

  
       
}
