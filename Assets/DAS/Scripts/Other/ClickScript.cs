//---------------------------------//
// Author: Eduardo Vicenzi Kuhn    //
// Date: 23/06/2019                //
// github.com/eduardovk            //
//---------------------------------//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickScript : MonoBehaviour
{
    public DAS_DialogueSystem dialogueSystem;


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction * 100, Color.green); // only draws once. Re-clicking does nothing
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == gameObject.name)
                {
                    Debug.Log("mouse clicked");
                    dialogueSystem.startDialogue();
                }
            }

        }
    }
}
