using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.UIElements;

public class FollowOffset : MonoBehaviour
{
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
        speed = 0.03f;
        Vector2 newPos = transform.position;
        newPos.x = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue()).x;
        xPos = newPos.x;
        yPos = newPos.x;
        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        //transform.position = newPos;
        


        if (xPos < 0)
        {
            if (xPos > prevXPos && prevXPos != xPos)
            {
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
            prevXPos = xPos;
    }

}
