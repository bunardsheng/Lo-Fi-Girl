using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookBatterySpriteChange : MonoBehaviour
{
    public Animator anim;

    // Update is called once per frame
    void Update()
    {
        if (Book.bookPickedUp)
        {
            anim.SetTrigger("bookPickedUp");
        }
    }
}
