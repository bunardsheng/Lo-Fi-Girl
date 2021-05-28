using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showTab : MonoBehaviour
{
    Rigidbody rb;
    public GameObject Panel;
    public bool showWindow = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && Headphones.headphonesPickedUp) 
        
        {
        showWindow = !showWindow;
        Panel.SetActive(showWindow);

        
        }
        

        
    }


}