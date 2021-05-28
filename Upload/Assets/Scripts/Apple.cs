using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public static bool appleEaten;
    private bool playerInRange;
    public List<SpriteChanger> spriteChanges;
    public Battery battery;

    // Update is called once per frame
    private void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E) && Headphones.headphonesPickedUp)
        {
            EatApple();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            playerInRange = false;
        }
    }

    private void EatApple()
    {
        foreach (SpriteChanger change in spriteChanges)
        {
            change.ChangeSprite();
        }
        appleEaten = true;
        PlayerSpriteChange.s.anim.SetTrigger("isEating");
        battery.DelayBatteryPickUp();
        GameObject dialogueMain = GameObject.FindGameObjectWithTag("Canvas");
        dialogueMain.transform.GetChild(0).gameObject.SetActive(true);
        dialogueMain.transform.GetChild(0).GetChild(0).gameObject.SetActive(true);
        dialogueSystem.dialogueHolder.showSequence("You ate the apple.");
        Destroy(gameObject);
    }
}
