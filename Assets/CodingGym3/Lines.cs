using UnityEngine;

public class Lines : MonoBehaviour
{
    public Transform start;
    public Transform end;
    //set timer
    public float t = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //run the timer for t; increasing t
        t += Time.deltaTime;
        //check if t has reached 1 if it has reset it to 0

        if(t > 1)
        {
            t = 0;
        }
        //set position of sprite + adding lerp positions and timer
        transform.position = Vector2.Lerp(start.position, end.position, t);
    }
}
