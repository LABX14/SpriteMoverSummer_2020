using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Color color;

    // Start is called before the first frame update
    void Start()
    {
        // this takes the sprite and changes the color and transparency of it
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        //spriteRenderer.color = color;
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
