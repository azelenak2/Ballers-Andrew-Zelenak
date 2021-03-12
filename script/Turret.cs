using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public GameObject target;
    public Transform TurretMovement;
    public Transform Gun;

    public float distance;
    public float damage;
    public float cooldown;
    public float time;
    public float lookspeed;


    public bool showDistance = false;

     void Start()
    {
        InvokeRepeating("FindTarget", 0, 0.5f);
    }

    void Update()
    {
       if(target != null)
        {
            tailTarget();
        }

        time += Time.deltaTime;

        if (time >= cooldown)
        {
            if (target != null)
            {
                time = 0;
                Fire();
            }
        }
    }
    void FindTarget()
    {
        Collider[] colls = Physics.OverlapSphere(transform.position, distance);

        float distanceaway = Mathf.Infinity;

        for(int i = 0; i < colls.Length; i++)
        {
            if(colls[i].tag == "Enemy")
            {
                float disn = Vector3.Distance(transform.position, colls[i].transform.position);
                if(disn <distanceaway)
                {
                    target = colls[i].gameObject;
                    distanceaway = disn;
                    
                   
                }
            }
        }
    }

    void tailTarget()
    {
        Vector3 targetdirection = target.transform.position = transform.position;
        targetdirection.y = 0;
        TurretMovement.forward = targetdirection;


    }

    void Fire()
    {

    }


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, distance);
    }
}
