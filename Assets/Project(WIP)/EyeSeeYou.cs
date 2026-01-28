using UnityEngine;
using UnityEngine.InputSystem;

public class EyeSeeYou : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //get mouse position and set it to eye
        Vector2 eye = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        transform.position = eye;

    }
}
