using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using dialogueSystem;

public class testDialogue : MonoBehaviour


{
    public GameObject canvas;
    public List<string> strings;
    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(true);
        dialogueHolder.showSequence("Welcome to Lo-Fi Girl! Use WASD to move around the room. Press E to pick up the headphones on the nightstand next to you. When you're ready, press Space to get rid of the text box.");
    }
        
    // private void NextDialogue()
    //{
        // canvas.SetActive(true);
        // dialogueHolder.showSequence(strings[num]);
    //}
}
