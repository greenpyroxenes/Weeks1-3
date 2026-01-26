using UnityEngine;

public class Lights : MonoBehaviour
{
    //set variables
    public Transform start;
    public Transform end;
    public float t;
    public AnimationCurve curve;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //have lights increase size then decrease to appear as they are "dancing" with the rest of the fruit\
        //use animation curve for size increase and decrease
        t += Time.deltaTime;
        if (t > 1)
        {
            t = 0;
        }

        float s = curve.Evaluate(t);
        transform.localScale = Vector2.one * s;
    }
}
