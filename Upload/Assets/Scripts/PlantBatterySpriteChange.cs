using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantBatterySpriteChange : MonoBehaviour
{
    public Animator anim;

    // Update is called once per frame
    void Update()
    {
        if (WateringCan.plantWatered)
        {
            anim.SetTrigger("plantWatered");
        }
    }
}
