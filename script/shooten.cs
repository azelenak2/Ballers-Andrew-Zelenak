using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooten : MonoBehaviour
{
    public float speed = 50f;

    public Transform targ;

    public void Seek(Transform _targ)
    {
        targ = _targ; 
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (targ == null)
        {
            Destroy(gameObject);
            return; 
        }

        Vector3 direct = targ.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if (direct.magnitude <= distanceThisFrame)

        {
            targHit();
        }

        transform.Translate(direct.normalized * distanceThisFrame, Space.World);


    }

    void targHit()
    {
        
    }
}
