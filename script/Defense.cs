using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defense : MonoBehaviour
{
    public AudioSource whoosh;
    public Transform ENEMY;
    public float shootDistance = 20f ;
    public Transform roto;
    public float shooting = 1f;
    public float cooldown = 0f;
    public GameObject projectile;
    public Transform firepostion;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("targetFunction", 0f, 0.5f); 
    }

    void targetFunction()
    {
        GameObject[] Enemy = GameObject.FindGameObjectsWithTag("Enemy");
        float minDistance = Mathf.Infinity;
        GameObject Closest = null;

        foreach(GameObject enemy in Enemy)
        {
            float EnemyShootRange = Vector3.Distance(transform.position, enemy.transform.position);

            if (EnemyShootRange < minDistance)
            {
                minDistance = EnemyShootRange;
                Closest = enemy;
            }
        }

        if (Closest != null && minDistance <= shootDistance)
        {
            ENEMY = Closest.transform;
        }
        else
            ENEMY = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (ENEMY == null)
            return;

        Vector3 direct = ENEMY.position - transform.position;
        Quaternion lookrotation= Quaternion.LookRotation(direct);
        Vector3 rota = lookrotation.eulerAngles;
        roto.rotation = lookrotation;

        if (cooldown <=0f)
        {
            Fire();

            cooldown = 1f / shooting;

        }

        cooldown -= Time.deltaTime;
        
    }

    void Fire()
    {
        GameObject shooter = (GameObject)Instantiate(projectile, firepostion.position, firepostion.rotation);
        shooten shooterScript = shooter.GetComponent<shooten>();
        
        if (shooter != null)
            shooterScript.Seek(ENEMY);

    }



    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, shootDistance);
    }
}
