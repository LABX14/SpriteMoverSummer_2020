using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject objectToDeactivate;
    public SpriteMovement componentToDisable;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this will quit the application 
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        // this will pause the game and freeze the player and their controls
        if (Input.GetKeyDown(KeyCode.P))
        {
            // this will return the opposite of what the player wants when the key is pressed
            componentToDisable.enabled = !componentToDisable.enabled;
        }
        // When Q is pressed then quit the application     
        if (Input.GetKeyDown(KeyCode.Q))
        {
            objectToDeactivate.SetActive(!objectToDeactivate.activeInHierarchy);
        }
    }
}
