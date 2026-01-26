using UnityEngine;

public class RandomPlacer : MonoBehaviour
{
    //set variables
    public float timer;
    public float xPos;
    public float yPos;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //set the light to a random position
        xPos = Random.Range(-10, 10);
        yPos = Random.Range(-5, 5);
        Vector2 newPos = new Vector2(xPos, yPos);
        transform.position = newPos;
    }

    // Update is called once per frame
    void Update()
    {
        //on a timer, make the light move to a new random position then reset the timer
        timer += Time.deltaTime;
        if (timer > 0.5f)
        {
            xPos = Random.Range(-10, 10);
            yPos = Random.Range(-5, 5);
            Vector2 newPos = new Vector2(xPos, yPos);
            transform.position = newPos;
            timer = 0;
        }
    }
}
