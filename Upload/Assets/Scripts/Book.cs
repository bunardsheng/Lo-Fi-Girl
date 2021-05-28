using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour
{
    private bool playerInRange;
    public static bool bookPickedUp;
    public List<SpriteChanger> spriteChanges;
    public Battery battery;

    // Update is called once per frame
    private void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E) && Headphones.headphonesPickedUp)
        {
            PickUpBook();
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

    private void PickUpBook()
    {
        foreach (SpriteChanger change in spriteChanges)
        {
            change.ChangeSprite();
        }

        bookPickedUp = true;

        // Dialogue appears

        battery.DelayBatteryPickUp();

        GameObject dialogueMain = GameObject.FindGameObjectWithTag("Canvas");
        dialogueMain.transform.GetChild(0).gameObject.SetActive(true);
        dialogueMain.transform.GetChild(0).GetChild(0).gameObject.SetActive(true);
        dialogueSystem.dialogueHolder.showSequence("You picked up the book and put it in the bookshelf.");

        // book in bookshelf no longer on floor
        Destroy(gameObject);

    }
}