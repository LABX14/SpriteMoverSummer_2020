using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMovement : MonoBehaviour
{
    // this is what determines the default speed for the ship
    public float shipSpeed = 0.1f;
    public float speedMultiplier = 2;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        //Space bar teleports player to origin
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = new Vector2(0.0f, 0.0f);
        }
        // Moves Sprite right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            // This controls the direction the sprite is going and it also includes the speed of it. 
            // The speed is determined by the "public float movingSpeed = 0.1f;"
            transform.position += Vector3.right * shipSpeed;
        }
        // Moves Sprite left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * shipSpeed;
        }
        // Moves Sprite up 
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * shipSpeed;
        }
        // Moves Sprite down
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * shipSpeed;
        }
        // Left Shift Key doubles speed when pressed down
        if (Input.GetKeyDown(KeyCode.LeftShift) && shipSpeed != shipSpeed * speedMultiplier)
        {
            shipSpeed *= speedMultiplier;
            Debug.Log("IncreaseSpeed: " + speedMultiplier);  /*$"increaseSpeed: {increaseSpeed} is this the right value"); <-- this also works */ 
        }
        // Once Left Shift is not being pressed, it goes back to its base speed
        else if(Input.GetKeyUp(KeyCode.LeftShift) && shipSpeed != shipSpeed / speedMultiplier)
        {
            shipSpeed /= speedMultiplier;
        }
    }
}
