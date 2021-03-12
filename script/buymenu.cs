
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class buymenu : MonoBehaviour
{
    TurretPlacement turretplacement;

    void Start()
    {
        turretplacement = TurretPlacement.inception; 
    }

    public void BuyGruntTurret()
    {
        turretplacement.HoverTurretBuild(turretplacement.gruntTurret);
    }

    public void BuyHeatSeekingTurret()
    {
        turretplacement.HoverTurretBuild(turretplacement.HeatSeekingMissle);
     }
   

    // Update is called once per frame
    void Update()
    {
        
    }
}
