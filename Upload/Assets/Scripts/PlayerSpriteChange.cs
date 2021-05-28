using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpriteChange : MonoBehaviour
{
    public static PlayerSpriteChange s;
    public Animator anim;

    private void Awake()
    {
        s = this;
        Messenger.AddListener(GameEvent.EVENT_0, LetPlayerMove);
    }

    // Update is called once per frame
    void Update()
    {
        if (!Headphones.headphonesPickedUp)
        {
            return;
        }
        else if (this.anim.GetCurrentAnimatorStateInfo(0).IsName("eating"))
        {
            GetComponent<PlayerMovement>().playerSpeed = 0;
        }

        else if (this.anim.GetCurrentAnimatorStateInfo(0).IsName("crouch_right") || this.anim.GetCurrentAnimatorStateInfo(0).IsName("crouch_left"))
        {
            GetComponent<PlayerMovement>().playerSpeed = 0;
        }
        else
        {
            GetComponent<PlayerMovement>().playerSpeed = 2;
        }
    }

    private void LetPlayerMove()
    {
        anim.SetTrigger("PutOnHeadphones");
        GetComponent<PlayerMovement>().playerSpeed = 2;
    }
}