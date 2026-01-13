using UnityEngine;

public class TheBouncer : MonoBehaviour
{

    float speedy = 0.01f;
    float speedx = 0.01f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos = transform.position;
        newPos.x += speedx;
        newPos.y += speedy;
        transform.position = newPos;
        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPos.x < 0 || screenPos.x > Screen.width)
        {
            speedx *= -1;
        }
        if (screenPos.y < 0 || screenPos.y > Screen.height)
        {
            speedy *= -1;
        }
    }
}
