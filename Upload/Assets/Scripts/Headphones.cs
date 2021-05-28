using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Headphones : MonoBehaviour
{
    private bool playerInRange;
    public static bool headphonesPickedUp = false;

    // Update is called once per frame
    private void Update()
    {
        if (playerInRange && Input.GetKey(KeyCode.E))
        {
            PickUpHeadphones();
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

    private void PickUpHeadphones()
    {
        headphonesPickedUp = true;

        //change background from black and white to muted color
        Messenger.Broadcast(GameEvent.EVENT_0);

        // headphones are now on head and no longer on table
        GameObject dialogueMain = GameObject.FindGameObjectWithTag("Canvas");
        dialogueMain.transform.GetChild(0).gameObject.SetActive(true);
        dialogueMain.transform.GetChild(0).GetChild(0).gameObject.SetActive(true);
        dialogueSystem.dialogueHolder.showSequence("Hmm... the headphones are almost dead. Maybe you left batteries somewhere around the room. Anyways, there's stuff to do. Press Tab to view your To-Do list.");

        Destroy(gameObject);


    }
}
