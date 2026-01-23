using UnityEngine;

public class BouncingBalll : MonoBehaviour
{
    float speedx= 0.01F;
    float speedy = 0.01F;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //make the circle bounce 
        Vector3 ballSpeed = transform.position;
        ballSpeed.x += speedx;
        ballSpeed.y += speedy;
        transform.position = ballSpeed;

        //check if circle is at the edge of the screen if it is then * speed by -1 if not do nothing
        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPos.x < 0 || screenPos.x > Screen.width)
        {
            speedx = speedx * -1;
        }

        if (screenPos.y < 0 || screenPos.y > Screen.height)
        {
            speedy = speedy * -1;
        }

    }
}
