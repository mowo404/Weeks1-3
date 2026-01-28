using UnityEngine;

public class Snowonmetongue : MonoBehaviour
{
    //decalre animationCruve variable
    public AnimationCurve pulse;

    
    public float t = 0f;
    public float timer = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //adjust snowflake scale to pulse 
        Vector3 snowpulse = Vector3.one;
        //scale it on the x and y axis and multiply by 0.2 to make it smaller
        snowpulse.x = pulse.Evaluate(t);
        snowpulse.y = pulse.Evaluate(t);
        transform.localScale = snowpulse;

        t += Time.deltaTime * 0.5f;

        //creating a decreasing timer through using delta time
        timer -= Time.deltaTime;

        //create a loop when t goes above 1 to make pulsing animation
        if ( t > 1f)
        {
            t = 0;
        }

        Vector3 snowpulse2 = transform.position;
        //timer to make teeth snowflake appear in scene
        if (timer < 0)
        {
            
            //position to move teeth snowflake up when timer goes up
            snowpulse2.y = 0;
            
        }

        //if timer is less than -5 return teeth snowflake back to position
        if (timer < -5)
        {
            timer = 7.5f;


            snowpulse2.y = -8.8f;
        }
        //placed on the outside to not distrub animation scale
        transform.position = snowpulse2;
    }
}
