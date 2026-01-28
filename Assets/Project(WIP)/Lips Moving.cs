using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 5F;

    public float timer = 10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {    
        
        Vector3 lipsmove = transform.position;
        //increasing x position of sprite by speed x time
        lipsmove.x += speed * Time.deltaTime;
        //set position of sprite to lipsmove variable

        //creating a decreasing timer through using delta time
        timer -= Time.deltaTime;


        //check dimesions of camera to bounce lips back through converting from world space to screen space
        Vector3 screenPos = Camera.main.WorldToScreenPoint(lipsmove);
        if(screenPos.x < 0 || screenPos.x > Screen.width)
        {

            speed = speed * -1;

        }

        if (timer < 0)
        {
            

            //position to hide closed lips to when timer goes up
            lipsmove.y = -10;

            
        }

        //if timer is less than -5 bring the closed lips back to the middle...
        if (timer < -5)
        {
            timer = 7.5f;


            lipsmove.y = 0;
            
            
        }
        //placed on the outside so lips movement is not disrubted 
        transform.position = lipsmove;
    }
}
