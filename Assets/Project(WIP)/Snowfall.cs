using UnityEngine;

public class Snowfall : MonoBehaviour
{
    public Transform start;
    public Transform end;

    public float t = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //run timer increasing t
        t+= Time.deltaTime;

        if (t > 1)
        {
            t = 0;
        }
        
        //set lerp positons
        transform.position = Vector2.Lerp(start.position, end.position, t); 
    }
}
