using UnityEngine;

public class FPController : MonoBehaviour
{

    float speed = 0.1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        // This uses x and z value to move around - this is where the movement magic happens
        transform.position += new Vector3(x * speed, 0, z * speed);
    }

}