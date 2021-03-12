using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Transform prefab;
    public GameObject[] objects;

    public Transform PointofSpawn;

    public float time;

    public float down;

    public int Num;
    void Update()
    {
        if (down <= 0f)
        {
            Spawner();

            down = time; 
        }

        down -= Time.deltaTime; 
    }

    void Spawner()
    {
        for (int i = 0; i < Num; i++)
        {
            SpawnE();
        }
        Num++;
    }

    void SpawnE()
    {
        Instantiate(prefab, PointofSpawn.position,PointofSpawn.rotation);

      

    }
}
