using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace dialogueSystem
{
    public class dialogueLine : dialogueBoxNew
    {   
        private Text textHolder;
        [Header ("Text Options")]
        [SerializeField] private string input;
        [SerializeField] private Color textColor;
        [SerializeField] private Font textFont;

        [Header ("Time Parameter")]
        [SerializeField] private float delay;

        [Header ("Sound")]
        [SerializeField] private AudioClip sound;

        [Header ("Character Image")]
        [SerializeField] private Sprite characterSprite;
        
       
        private void Awake()
        {
            
            textHolder = GetComponent<Text>();
            textHolder.text = "";
        }
        public void DisplayString(string s)
        
        {
            StopAllCoroutines();
            StartCoroutine(WriteText(s, textHolder, textColor, textFont, delay, sound));
        }
    }  
}
