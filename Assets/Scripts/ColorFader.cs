using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Ross was here
public class ColorFader : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color32 color;

    [Range(0, 255)]
    public int r = 255;
    [Range(0, 255)]
    public int g;
    [Range(0, 255)]
    public int b;

    // Start is called before the first frame update
    void Start()
    {
        color = new Color(r,g,b);
    }

    // Update is called once per frame
    void Update()
    {
        r = color.r;
        g = color.g;
        b = color.b;

        // Changes RGB of spriteRenderer 
        spriteRenderer.color = color;
        if(color.r == 255 && color.g != 255 && color.b == 0)
        {
            color.g++;
        }
        else if(color.r != 0 && color.g == 255 && color.b == 0)
        {
            color.r--;
        }
        else if(color.r == 0 && color.g != 0 && color.b != 255)
        {
            color.b++;
        }
        else if(color.r == 0 && color.g != 0 && color.b == 255)
        {
            color.g--;
            Debug.Log("g--");
        }
        else if (color.r != 255 && color.g == 0 && color.b != 0)
        {
            color.b--;
            color.r++;
        }
    }
}
