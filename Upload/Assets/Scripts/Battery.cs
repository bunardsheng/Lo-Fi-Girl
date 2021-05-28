using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour
{
    private bool playerInRange;
    public Animator anim;

    // Update is called once per frame
    private void Start()
    {
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
    }

    private void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E) && Headphones.headphonesPickedUp)
        {
            PickUpBattery();
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

    private void PickUpBattery()
    {
        // Triggers event animation and then environmental progression if applicable (using a battery count)
        // Battery disappears from the scene
        // Text box
        
        BatteryCounter.numBatteries += 1;
        BatteryCounter.CallProgression();
        //if numbatteries hits a certain number, call whatever event correlated
        GameObject dialogueMain = GameObject.FindGameObjectWithTag("Canvas");
        dialogueMain.transform.GetChild(0).gameObject.SetActive(true);
        dialogueMain.transform.GetChild(0).GetChild(0).gameObject.SetActive(true);
        dialogueSystem.dialogueHolder.showSequence("You picked up a battery.");

        PlayerSpriteChange.s.anim.SetTrigger("isPickingUp");

        if (BatteryCounter.numBatteries == 1)
        {
            dialogueSystem.dialogueHolder.showSequence("You picked up a battery. Everything seems to have brightened up a bit.");
        }
        else if (BatteryCounter.numBatteries == 3)
        {
            dialogueSystem.dialogueHolder.showSequence("Nice! Your headphones are now at 50% and you unlocked a new song!");
        }
        else if (BatteryCounter.numBatteries == 6)
        {
            dialogueSystem.dialogueHolder.showSequence("Congratulations! Your headphones are fully charged and you've helped Lo-Fi Girl feel just a little better. Thanks for playing :)");
        }

        Destroy(gameObject);
    }

    public void DelayBatteryPickUp()
    {
        StartCoroutine(DelayBatteryPickUpCoroutine());
    }

    public IEnumerator DelayBatteryPickUpCoroutine()
    {
        yield return null;
        gameObject.GetComponent<BoxCollider2D>().enabled = true;
    }
}
