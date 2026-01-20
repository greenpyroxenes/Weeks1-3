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

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos = transform.position;
        newPos.x = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue()).x;
        xPos = newPos.x;
        yPos = newPos.y;
        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        //transform.position = newPos;


        if (xPos < 0)
        {
            if (xPos > prevXPos && prevXPos != xPos)
            {
                if (yPos < Screen.height - 0.5)
                {
                    newPos.y += Time.deltaTime * 10;
                    transform.position = newPos;
                }
            }
            else if (xPos < prevXPos && prevXPos != xPos)
            {
                if (yPos < Screen.height - 0.5)
                {
                    newPos.y -= Time.deltaTime * 10;
                    transform.position = newPos;
                }
            }
        }
        else if(xPos > 0)
        {
            if(xPos > prevXPos && prevXPos != xPos)
            {
                newPos.y -= Time.deltaTime * 3;
                transform.position = newPos;
            }
            else if(xPos < prevXPos && prevXPos != xPos)
            {
                newPos.y += Time.deltaTime * 3;
                transform.position = newPos;
            }
        }
            prevXPos = xPos;
    }

}
