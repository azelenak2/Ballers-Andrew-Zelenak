using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Builderscript : MonoBehaviour
{
    public static Builderscript inception;


    

    void Awake()
    {
        inception = this;  
    }
    
    private Skelly turretpicked;
    public GameObject GruntTurret;
    public GameObject HeatSeekingBullet;
   public void Buildaturrets(TouchingPoint touch)
    {
        if (cashmoney.dacash < turretpicked.cost)
        {
            return; 
        }
        cashmoney.dacash -= turretpicked.cost;
        GameObject turd = Instantiate(turretpicked.prefab, touch.buildersPos(), Quaternion.identity);
        touch.turret = turd; 
    }

   

    public bool Build { get { return turretpicked != null; } }
   public void PickedTurretToBuild(Skelly turret)
    {
        turretpicked = turret; 
    }


    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        
    }
}
