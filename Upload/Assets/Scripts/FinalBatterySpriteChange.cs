using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalBatterySpriteChange : MonoBehaviour
{
    public Animator anim;
    public Battery battery;

    // Update is called once per frame
    void Update()
    {
        if (BatteryCounter.numBatteries == 5) 
        {
            anim.SetTrigger("finalBattery");
            battery.DelayBatteryPickUp();
            Destroy(this);
        }
    }
}
