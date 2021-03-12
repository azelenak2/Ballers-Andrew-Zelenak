using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform targ;
    private int pointindex = 0;
    public float speed; 


    void Start()
    {
        targ = point.pnts[0];
    }

     void Update()
    {

        
        Vector3 direction = targ.position - transform.position;
        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);

        if(Vector3.Distance(transform.position, targ.position)<= 0.2)
        {
            NxtPint();
        }

        void NxtPint()
        {
            
            pointindex++;
            targ = point.pnts[pointindex];
        }
    }
}
