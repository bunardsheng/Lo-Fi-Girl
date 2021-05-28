using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;


namespace dialogueSystem
{
    
    public class dialogueHolder : MonoBehaviour
    {
        
        public static dialogueHolder staticHolder;

        public static void showSequence(List<string> strings){
            staticHolder.displaySequence(strings);}
        
        public static void showSequence(string indivString){
            List<string> myList = new List<string>();
            myList.Add(indivString);

            staticHolder.displaySequence(myList);
        }

        
        
        public dialogueLine line;
        
        private void Awake()
        {
            
            staticHolder = this;
            //StartCoroutine(dialogueSequence(strings));
        }

        private IEnumerator dialogueSequence(List<string> strings)
        {               
            for (int i = 0; i < strings.Count; i++)
            {
                line.DisplayString(strings[i]);
                yield return new WaitUntil(() => line.finished);

            }
            Deactivate();
        }
        public void displaySequence(List<string> showSequence)
        {
            StartCoroutine(dialogueSequence(showSequence));

        }
    // Update is called once per frame
        private void Deactivate()
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                
                transform.GetChild(i).gameObject.SetActive(false);
            }   
            transform.gameObject.SetActive(false);
         }
           
    }
}
