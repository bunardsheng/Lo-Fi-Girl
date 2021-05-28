using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleBatterySpriteChange : MonoBehaviour
{
    public Animator anim;

    // Update is called once per frame
    void Update()
    {
        if (Apple.appleEaten)
        {
            anim.SetTrigger("appleEaten");
        }
    }
}
