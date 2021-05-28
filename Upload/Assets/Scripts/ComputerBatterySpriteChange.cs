using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerBatterySpriteChange : MonoBehaviour
{
    public Animator anim;

    // Update is called once per frame
    void Update()
    {
        if (Computer.computerTurnedOn)
        {
            anim.SetTrigger("computerTurnedOn");
            Destroy(this);
        }
    }
}
