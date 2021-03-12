using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class healthforplayer : MonoBehaviour
{
    public secondhealth heal;
    public int maxhelth = 90;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (maxhelth <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            heal.maxhealth--;
        }




    }
}
