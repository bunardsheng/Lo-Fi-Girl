using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantGrowAnimation : MonoBehaviour
{
    public Animator anim;

    // Update is called once per frame
    void Update()
    {
        if (WateringCan.plantWatered)
        {
            anim.SetTrigger("plantWatered");
        }
        
        if (BatteryCounter.numBatteries == 6)
        {
            anim.SetTrigger("finalBatteryPickedUp");
        }
    }
}
