using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace dialogueSystem
{

    public class dialogueBoxNew : MonoBehaviour
    {   

        public bool finished;
        protected IEnumerator WriteText(string input, Text textHolder, 
        Color textColor, Font textFont, float delay, AudioClip sound)
        {   
            textHolder.color = textColor;
            textHolder.font = textFont;
            finished = false;
            textHolder.text = "";
            
            for(int i = 0; i<input.Length; i++)
            {
                textHolder.text += input[i];
                // play the sound
                
                yield return new WaitForSeconds(delay);
               
            }
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
            finished = true;

        }
    }
}

    
    