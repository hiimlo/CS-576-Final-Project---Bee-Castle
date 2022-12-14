using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PauseMenu : MonoBehaviour
{
    public bool paused;
    public TMP_Text str;
    // Start is called before the first frame update
    void Start()
    {
        paused = false;
        str.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        //if (Keyboard.current[KeyCode.Escape].wasPressedThisFrame())
        if (Input.GetKey(KeyCode.Escape))
        {
            paused = !paused;
        }
        
        if (paused)
        {
            Time.timeScale = 0;

            str.text = "Paused";
        } else
        {
            Time.timeScale = 1;

            str.text = "";
        }
    }
}
