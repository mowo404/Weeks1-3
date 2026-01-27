using UnityEngine;

public class GIMMIEMYLIME : MonoBehaviour
{
    public float timer = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //creating a decreasing timer through using delta time
        timer -= Time.deltaTime;

        if(timer  < 0)
        {
            Vector3 openlips = transform.position;
            //position to move openlips to when timer goes up
            openlips.y = 0;
            transform.position = openlips;
        }

        if (timer < -5)
        {
            timer = 10;


            Vector3 openlips = transform.position;
            //position to move openlips to when timer goes up
            openlips.y = -10;
            transform.position = openlips;
        }
    }
}
