using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMovement : MonoBehaviour
{
    // this is what determines the default speed for the ship
    public float movingSpeed = 0.1f;
    public float increaseSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            // This controls the direction the sprite is going and it also includes the speed of it. 
            // The speed is determined by the "public float movingSpeed = 0.1f;"
            transform.position += Vector3.right * movingSpeed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * movingSpeed;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * movingSpeed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * movingSpeed;
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
           movingSpeed += increaseSpeed * 2;
        }
        else
        {
            movingSpeed /= 2;
        }
    }
}
