using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firstenemyhealth : MonoBehaviour
{
    

    void OnTriggerEnter( Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            Destroy(this.gameObject);
        }


    }
}
