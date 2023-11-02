using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnClick : MonoBehaviour
{

    //variables for the game
    float speed = 10f;              //control the speed of movvement

    Vector2 lastMousePos;           //store the position of the mouse

    bool moving;                    //keep track of movement

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))        //if left button is clicked
        {
            lastMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); //chage the value of lastMousePos to the current position of the mouse
            moving = true;      //change moving to true/object is moving
        }

        if (moving && (Vector2)transform.position != lastMousePos)      //if object is moving and is not at the last position of the mouse
        { 
            float step = speed * Time.deltaTime;        //create a variable for the movement
            transform.position = Vector2.MoveTowards(transform.position, lastMousePos, step);   //move the object to the new last position of the mouse
        }

        else
        {
            moving = false;
        }
    }
}
