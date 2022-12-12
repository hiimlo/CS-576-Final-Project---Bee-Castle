using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PauseMenu : MonoBehaviour
{
    private bool paused;
    // Start is called before the first frame update
    void Start()
    {
        paused = false;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Keyboard.current[KeyCode.Escape].wasPressedThisFrame())
        if (Input.GetKey(KeyCode.Escape))
        {
            Debug.Log("pause");
            paused = !paused;
        }
        
        if (paused)
        {
            Time.timeScale = 0;
        } else
        {
            Time.timeScale = 1;
        }
    }
}
