using UnityEngine;

public class Clock : MonoBehaviour
{
    public float rotationSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        Vector3 currentRotation = transform.eulerAngles;
        currentRotation.z += rotationSpeed * Time.deltaTime;

        transform.eulerAngles = currentRotation;

    }
}
