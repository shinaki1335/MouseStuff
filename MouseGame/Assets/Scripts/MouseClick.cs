using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Check for mouse buttons being pressed
        if (Input.GetMouseButtonDown(0))        //if left button is pressed 
        {
            Debug.Log("Left Click");            //show in console
        }

        if (Input.GetMouseButtonDown(1))        //if right button is pressed
        {
            Debug.Log("Right Click");           //show in console
        }

        if (Input.GetMouseButtonDown(2))         //if middle button is pressed
        {
            Debug.Log("Middle Click");           //show in console
        }
    }

}
