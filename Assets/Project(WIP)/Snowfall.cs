using UnityEngine;

public class Snowfall : MonoBehaviour
{
    public float start = 5f;
    public float end = -5f;

    public float t = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //set snowflake position to random for each one
        t=Random.Range(0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        //run timer increasing t
        t+= Time.deltaTime;

        //reset snowfall if t is greater than 1
        if (t > 1)
        {
            t = 0;
        }

        //set lerp positons
        Vector2 snowfall = transform.position;
        //lerping only the y float
        snowfall.y = Mathf.Lerp(start, end, t);
        transform.position = snowfall;
    }
}
