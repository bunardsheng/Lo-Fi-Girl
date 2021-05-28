using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computer : MonoBehaviour
{
    private bool playerInRange;
    public static bool computerTurnedOn;
    public List<SpriteChanger> spriteChanges;
    public Battery battery;

    // Start is called before the first frame update
    // Update is called once per frame
    private void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E) && Headphones.headphonesPickedUp)
        {
            TurnOnComputer();
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

    private void TurnOnComputer()
    {
        foreach (SpriteChanger change in spriteChanges)
        {
            change.ChangeSprite();
        }

        //dialogue
        computerTurnedOn = true;

        battery.DelayBatteryPickUp();

        GameObject dialogueMain = GameObject.FindGameObjectWithTag("Canvas");
        dialogueMain.transform.GetChild(0).gameObject.SetActive(true);
        dialogueMain.transform.GetChild(0).GetChild(0).gameObject.SetActive(true);
        dialogueSystem.dialogueHolder.showSequence("You turned on the computer.");
        Destroy(this);
    }
}
