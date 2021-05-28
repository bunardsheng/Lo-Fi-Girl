using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WateringCan : MonoBehaviour
{
    public static bool plantWatered;
    private bool playerInRange;
    public List<SpriteChanger> spriteChanges;
    public Battery battery;

    // Update is called once per frame
    private void Update()
    {
        if (playerInRange && Input.GetKey(KeyCode.E) && Headphones.headphonesPickedUp)
        {
            WaterPlant();
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

    private void WaterPlant()
    {
        foreach(SpriteChanger change in spriteChanges)
        {
            change.ChangeSprite();
        }
        //dialogue
        plantWatered = true;
        battery.DelayBatteryPickUp();
        GameObject dialogueMain = GameObject.FindGameObjectWithTag("Canvas");
        dialogueMain.transform.GetChild(0).gameObject.SetActive(true);
        dialogueMain.transform.GetChild(0).GetChild(0).gameObject.SetActive(true);
        dialogueSystem.dialogueHolder.showSequence("You watered the plant.");
        Destroy(this);
    }
}
