using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisableGetPart : MonoBehaviour
{
    public GameObject gp;
    public PauseMenu pause_menu;

    public void EnableCanvas() {
        gp.SetActive(true);
        pause_menu.paused = true;
        pause_menu.str.enabled = false;
    }

    public void DisableCanvas() {
        gp.SetActive(false);
        pause_menu.paused = false;
        pause_menu.str.enabled = true;
    }
}
