using UnityEngine;
using UnityEngine.UIElements;

public class Teleporting : MonoBehaviour
{

    private float start = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        start += Time.deltaTime;

        if (start < 4f)
        {
            transform.position = Random.insideUnitCircle * 2f;
        }
    }
}
