using UnityEngine;

public class RandomPlacer : MonoBehaviour
{
    public float timer;
    public float xPos;
    public float yPos;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        xPos = Random.Range(-10, 10);
        yPos = Random.Range(-5, 5);
        Vector2 newPos = new Vector2(xPos, yPos);
        transform.position = newPos;
    }

    // Update is called once per frame
    void Update()
    {
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
