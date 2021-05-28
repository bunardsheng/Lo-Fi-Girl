using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatFood : MonoBehaviour
{
    private bool playerInRange;
    public static bool bowlFilled;
    public List<SpriteChanger> spriteChanges;
    public Battery battery;
    
    // Start is called before the first frame update
    // Update is called once per frame
    private void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E) && Headphones.headphonesPickedUp)
        {
            FillBowl();
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

    private void FillBowl()
    {
        foreach (SpriteChanger change in spriteChanges)
        {
            change.ChangeSprite();
        }

        //dialogue
        bowlFilled = true;

        battery.DelayBatteryPickUp();

        gameObject.GetComponent<BoxCollider2D>().enabled = false;

        GameObject dialogueMain = GameObject.FindGameObjectWithTag("Canvas");
        dialogueMain.transform.GetChild(0).gameObject.SetActive(true);
        dialogueMain.transform.GetChild(0).GetChild(0).gameObject.SetActive(true);
        dialogueSystem.dialogueHolder.showSequence("You filled the bowl with cat food.");
        Destroy(this);
    }
}
