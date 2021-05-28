using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WateringCanAnimation : MonoBehaviour
{
    public Animator anim;

    // Update is called once per frame
    void Update()
    {
        if (WateringCan.plantWatered)
        {
            anim.SetTrigger("isWatering");
        }
    }
}
