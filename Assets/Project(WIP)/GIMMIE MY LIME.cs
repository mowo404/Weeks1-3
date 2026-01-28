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


        //hide lips again if timer is less than -5
        if (timer < -5)
        {
            timer = 7.5f;


            Vector3 openlips = transform.position;
            //position to move open lips back to when timer condition is met
            openlips.y = -8.8f;
            transform.position = openlips;
        }
    }
}
