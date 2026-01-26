using UnityEngine;

public class Sliding : MonoBehaviour
{
    //set the varibles
    public Transform start;
    public Transform end;
    public float t;
    public AnimationCurve curve;
    public float prevxPos;
    public float xPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //have the object lerp on an animation curve
        t += Time.deltaTime;
        if (t > 2)
        {
            t = 0;
        }

        transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(t));
        prevxPos = xPos;
        xPos = transform.position.x;
    }
}
