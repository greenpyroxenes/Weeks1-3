using UnityEngine;

public class Jumpy : MonoBehaviour
{
    //set varibles
    float jump = 0.01f;
    public float yPos;
    public float xPos;
    float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //have the object move towards the left constantly
        //have the object move on the y axis depending on what y value it is at, wether its up or down.
        //if object reaches end of screen, make it set to the other end to have an endless loop
        Vector2 newPos = transform.position;
        speed = Time.deltaTime + 0.01f;
        newPos.x -= speed;
        newPos.y += jump;
        yPos = newPos.y;
        xPos = newPos.x;
        if(yPos > -1.5f)
        {
            jump *= -1;
        }
        if(yPos < -3.5f)
        {
            jump *= -1;
        }
        if(xPos < -12)
        {
            xPos = 12;
            newPos.x = xPos;
        }
        transform.position = newPos;
    }
}
