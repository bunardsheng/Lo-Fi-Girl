using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatFoodBatterySpriteChange : MonoBehaviour
{
    public Animator anim;

    // Update is called once per frame
    void Update()
    {
        if (CatFood.bowlFilled)
        {
            anim.SetTrigger("bowlFilled");
            Destroy(this);
        }
    }
}
