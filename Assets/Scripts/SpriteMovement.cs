using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMovement : MonoBehaviour
{
    // this is what determines the default speed for the ship
    public float movingSpeed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // This controls the direction the sprite is going and it also includes the speed of it. 
        // The speed is determined by the "public float movingSpeed = 0.1f;"
        transform.position += Vector3.right * movingSpeed;
    }
}
