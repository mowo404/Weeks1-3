using UnityEngine;

public class SquareMover : MonoBehaviour
{
    //public variables go here:
    public float xMax = 5;
    public float xMin = -5;
    public float speed = 0.025F;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
            
     
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.x = newPosition.x + speed;
        transform.position = newPosition;

        //if statement that moves the square to the left when it is greater than our max...
        if (newPosition.x > xMax)
        {
            speed = speed *= -1;
        }

        //if statement that moves the square to the right when it is less than our min...
        if (newPosition.x < xMin)
        {
            speed = speed *= -1;
        }
    }
}
