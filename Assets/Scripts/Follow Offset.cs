using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.UIElements;

public class FollowOffset : MonoBehaviour
{
    //Varibles for positions and speed
    public float xPos;
    public float yPos;
    public float prevXPos;
    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Set the speed the speed to a set number
        speed = 0.03f;
        //Have the obejct follow the mouse but only with the x axis
        //Set the xPos to be the yPos to have it follow the same path so mouse speed isnt an issue
        Vector2 newPos = transform.position;
        newPos.x = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue()).x;
        xPos = newPos.x;
        yPos = newPos.x;
        

        //check to see if mouse position is on the left side or right side of screen and make it move up or down accordingly
        if (xPos < 0)
        {
            //check to see if the mouse is increasing or decreasing and make the object move up or down accordingly
            if (xPos > prevXPos && prevXPos != xPos)
            {
                //Offset of 3 to make it show properly
                    newPos.y = xPos + 3;
                    transform.position = newPos;
            }
            else if (xPos < prevXPos && prevXPos != xPos)
            {
                    newPos.y = xPos + 3;
                    transform.position = newPos;
            }
        }
        else if(xPos > 0)
        {
            if(xPos > prevXPos && prevXPos != xPos)
            {
                newPos.y = (-1 * xPos) + 3;
                transform.position = newPos;
            }
            else if(xPos < prevXPos && prevXPos != xPos)
            {
                newPos.y = (-1 * xPos) + 3;
                transform.position = newPos;
            }
        }
        //set previous x position to x position at end so movement happens before old position gets updated
            prevXPos = xPos;
    }

}
