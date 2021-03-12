using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretPlacement : MonoBehaviour
{
    public static TurretPlacement inception; 
    private GameObject Turrettime;



    public GameObject GetTurretbuilt()
    {
        return Turrettime;

    }

    private void Awake()
    {
        inception = this; 
    }

    public GameObject gruntTurret;
    public GameObject HeatSeekingMissle;
    // Start is called before the first frame update
  

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HoverTurretBuild(GameObject turret)
    {
        Turrettime = turret; 
    }
}
